using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public  class Rover
    {
        public int x;//
        public int y;//
        public string direction;//

        public Rover(string location)
        {
            Int32.TryParse(location.Split(' ')[0], out x);
            Int32.TryParse(location.Split(' ')[1], out y);
            direction = location.Split(' ')[2];
        }
        public void SpinLeft()
        {
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;
                default:
                    throw new ArgumentException();
                    break;
            }
        }
        
        public void SpinRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
                    break;
            }
        }
        
        public void StepForward()
        {
            switch (direction)
            {
                case "N":
                    y += 1;
                    break;
                case "E":
                    x += 1;
                    break;
                case "S":
                    y -= 1;
                    break;
                case "W":
                    x -= 1;
                    break;
                default:
                    throw new ArgumentException();
                    break;
            }
        }
        public void Move(string roverCommand) // LMLMLMLMM or MMRMMRMRRM
        {
            char[] instruction = roverCommand.ToCharArray();
            for (int i = 0; i < instruction.Length; i++)
            {
                switch (instruction[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        StepForward();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }

        }
    }
}
