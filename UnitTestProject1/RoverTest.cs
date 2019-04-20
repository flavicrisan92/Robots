using System;
using FlaviusTestR;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class RoverTest
    {
        public IRover Rover { get; set; }
        PositionsMap PositionsMap { get; set; }
        public RoverTest()
        {
            PositionsMap = new PositionsMap();          
        }

        [TestMethod]
        public void TestMethod_ChangeOrientationToLeft()
        {
            //Arrange
            var firstOrietation = PositionsMap.OrientationToNumber["N"];
            Rover = new Rover(1, 2, firstOrietation, PositionsMap);

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
            Rover = new Rover(1, 2, firstOrietation, PositionsMap);

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
            Rover = new Rover(1, 2, firstOrietation, PositionsMap);

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
            Rover = new Rover(1, 2, firstOrietation, PositionsMap);

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
            Rover = new Rover(1, 2, firstOrietation, PositionsMap);

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
            Rover = new Rover(1, 2, firstOrietation, PositionsMap);

            //Act
            Rover.ExecuteInstructions("R1", "R");

            //Asser
            Assert.AreEqual(Rover.GetOrientation(), 0);
        }        
    }
}
