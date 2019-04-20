using System;
using FlaviusTestR;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class RoverTest
    {
        public IRover Rover { get; set; }

        [TestMethod]
        public void TestMethod_ChangeOrientationToLeft()
        {
            //Arrange
            var firstOrietation = PositionsMap.OrientationToNumber["N"];
            Rover = new Rover(1, 2, firstOrietation);

            //Act
            Rover.ExecuteInstructions("R1", "L");

            //Asser
            Assert.AreEqual(Rover.GetOrientation(), 3);
        }

        [TestMethod]
        public void TestMethod_ChangeOrientationToRight()
        {
            //Arrange
            var firstOrietation = PositionsMap.OrientationToNumber["N"];
            Rover = new Rover(1, 2, firstOrietation);

            //Act
            Rover.ExecuteInstructions("R1","R");

            //Asser
            Assert.AreEqual(Rover.GetOrientation(), 1);
        }

        [TestMethod]
        public void TestMethod_Move_WhenNorth()
        {
            //Arrange
            var firstOrietation = PositionsMap.OrientationToNumber["N"];
            Rover = new Rover(1, 2, firstOrietation);

            //Act
            Rover.ExecuteInstructions("R1", "M");

            //Asser
            Assert.AreEqual(Rover.GetY(), 3);
        }

        [TestMethod]
        public void TestMethod_Move_WhenFaceToEast()
        {
            //Arrange
            var firstOrietation = PositionsMap.OrientationToNumber["E"];
            Rover = new Rover(1, 2, firstOrietation);

            //Act
            Rover.ExecuteInstructions("R1", "M");

            //Asser
            Assert.AreEqual(Rover.GetX(), 2);
        }

        [TestMethod]
        public void TestMethod_DecreaseOrientation_WhenZeroReset()
        {
            //Arrange
            var firstOrietation = PositionsMap.OrientationToNumber["N"];
            Rover = new Rover(1, 2, firstOrietation);

            //Act
            Rover.ExecuteInstructions("R1", "L");

            //Asser
            Assert.AreEqual(Rover.GetOrientation(), 3);
        }

        [TestMethod]
        public void TestMethod_ChangeOrientation_WhenThreeReset()
        {
            //Arrange
            var firstOrietation = PositionsMap.OrientationToNumber["V"];
            Rover = new Rover(1, 2, firstOrietation);

            //Act
            Rover.ExecuteInstructions("R1", "R");

            //Asser
            Assert.AreEqual(Rover.GetOrientation(), 0);
        }

        [TestMethod]
        public void TestMethod_MultipleInstructionsRover1()
        {
            //Arrange
            var rover1Orietation = PositionsMap.OrientationToNumber["N"];
            var rover2Orietation = PositionsMap.OrientationToNumber["E"];
            var rover1 = new Rover(1, 2, rover1Orietation);
            var rover2 = new Rover(3, 3, rover2Orietation);

            //Act
            rover1.ExecuteInstructions("R1", "LMLMLMLMM");
            rover2.ExecuteInstructions("R2", "MMRMMRMRRM");

            //Asser
            Assert.AreEqual(rover1.GetX(), 1);
            Assert.AreEqual(rover1.GetY(), 3);
            Assert.AreEqual(rover1.GetOrientation(), 0);

            Assert.AreEqual(rover2.GetX(), 5);
            Assert.AreEqual(rover2.GetY(), 1);
            Assert.AreEqual(rover2.GetOrientation(), 1);
        }
    }
}
