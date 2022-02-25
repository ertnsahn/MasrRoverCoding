using System;
using Xunit;
using MarsRover;

namespace MarsRoverTest
{
    public class RoverShould
    {
        [Fact]
        public void SpinLeft()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.SpinLeft();
            //assert
            //Assert.True(rover.direction=="W");
            Console.WriteLine(rover.direction);
            Assert.Equal("W", rover.direction);
        }
        [Fact]
        public void SpinRight()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.SpinRight();
            //assert
            Assert.Equal("E", rover.direction);
        }
        [Fact]
        public void StepForward()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.StepForward();
            //assert
            Assert.Equal(3, rover.y);
        }
        [Fact]
        public void Move()
        {
            //arrange
            Rover rover = new Rover("3 3 E"); //or 12N
            //act
            rover.Move("MMRMMRMRRM"); //or LMLMLMLMM
            //assert
            Assert.Equal("5 1 E", rover.x + " " +  rover.y + " " + rover.direction); // or 13N
        }
    }
}
