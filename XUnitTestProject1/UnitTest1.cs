using System;
using TestingAssignment2.Models;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //1
        [Fact]
        public void Task_UpperCase()
        {
            //Arrange
            var str = "gateway group";
            var expectedString = "GATEWAY GROUP";

            //Act
            var result = StringOp.UpperCase(str);

            //Assert
            Assert.Equal(expectedString, result);
        }

        //2
        [Fact]
        public void Task_LowerCase()
        {
            //Arrange
            var str = "GATEWAY GROUP";
            var expectedString = "gateway group";

            //Act
            var result = StringOp.LowerCase(str);

            //Assert
            Assert.Equal(expectedString, result);
        }

        //3
        [Fact]
        public void Task_TitleCase()
        {
            //Arrange
            var str = "gateway group";
            var expectedString = "Gateway Group";

            //Act
            var result = StringOp.TitleCase(str);

            //Assert
            Assert.Equal(expectedString, result);
        }

        //4
        [Fact]
        public void Task_InLower()
        {
            //Arrange
            var str = "GateWay Group";
            var expectedString = "ateay roup";

            //Act
            var result = StringOp.InLower(str);

            //Assert
            Assert.Equal(expectedString, result);
        }

        //5
        [Fact]
        public void Task_FirstUpper()
        {
            //Arrange
            var str = "gateway group";
            var expectedString = "Gateway group";

            //Act
            var result = StringOp.FirstUpper(str);

            //Assert
            Assert.Equal(expectedString, result);
        }

        //6
        [Fact]
        public void Task_HasNumeric()
        {
            //Arrange
            var str = "Gateway Group1";
            var expectedString = "true";

            //Act
            var result = StringOp.FirstUpper(str);

            //Assert
            Assert.Equal(expectedString, result);
        }

        //7
        [Fact]
        public void Task_InUpper()
        {
            //Arrange
            var str = "Gateway Group";
            var expectedString = "GG";

            //Act
            var result = StringOp.InUpper(str);

            //Assert
            Assert.Equal(expectedString, result);
        }

        //8
        [Fact]
        public void Task_RemoveLast()
        {
            //Arrange
            var str = "Gateway Group";
            var expectedString = "Gateway Grou";

            //Act
            var result = StringOp.RemoveLast(str);

            //Assert
            Assert.Equal(expectedString, result);
        }

        //9
        [Fact]
        public void Task_WordCount()
        {
            //Arrange
            var str = "Gateway Group";
            var expectedString = "13";

            //Act
            var result = StringOp.WordCount(str);

            //Assert
            Assert.Equal(expectedString, result);
        }

        //10
        [Fact]
        public void Task_ConvertToInt()
        {
            //Arrange
            var str = "111";
            var expectedString = "111";

            //Act
            var result = StringOp.ConvertToInt(str);

            //Assert
            Assert.Equal(expectedString, result);
        }
    }
}
