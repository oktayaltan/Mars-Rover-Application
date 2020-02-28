using System;
using System.Linq;

namespace HBMarsRoverApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Format(@"5 5
                                     1 2 N
                                     LMLMLMLMM
                                     3 3 E
                                     MMRMMRMRRM").Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            var maxPoints = input[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToList();
            var result = new System.Text.StringBuilder();
            for (int i = 1; i < input.Length; i += 2)
            {
                var startPositions = input[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Position position = new Position();
                if (startPositions.Count() == 3)
                {
                    position.X = Convert.ToInt32(startPositions[0]);
                    position.Y = Convert.ToInt32(startPositions[1]);
                    position.Direction = (Directions)Enum.Parse(typeof(Directions), startPositions[2]);
                }

                var moves = input[i + 1].ToString().Trim().ToUpper();

                try
                {
                    position.StartMoving(maxPoints, moves);
                    result.Append($"{position.X} {position.Y} {position.Direction.ToString()}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.Write(result);
            Console.ReadLine();
        }
    }
}
