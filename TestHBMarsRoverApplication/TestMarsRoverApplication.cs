using HBMarsRoverApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestHBMarsRoverApplication
{
    [TestClass]
    public class TestMarsRoverApplication
    {
        [TestClass]
        public class MarsRoverProblemTest
        {
            [TestMethod]
            public void Should_Pass_Test_Scenario_12N_LMLMLMLMM()
            {
                Position position = new Position()
                {
                    X = 1,
                    Y = 2,
                    Direction = Directions.N
                };

                var maxPoints = new List<int>() { 5, 5 };
                var moves = "LMLMLMLMM";

                position.StartMoving(maxPoints, moves);

                var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";
                var expectedOutput = "1 3 N";

                Assert.AreEqual(expectedOutput, actualOutput);
            }

            [TestMethod]
            public void Should_Pass_Test_Scenario_33E_MRRMMRMRRM()
            {
                Position position = new Position()
                {
                    X = 3,
                    Y = 3,
                    Direction = Directions.E
                };

                var maxPoints = new List<int>() { 5, 5 };
                var moves = "MRRMMRMRRM";

                position.StartMoving(maxPoints, moves);

                var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";
                var expectedOutput = "2 3 S";

                Assert.AreEqual(expectedOutput, actualOutput);
            }
        }
    }
}
