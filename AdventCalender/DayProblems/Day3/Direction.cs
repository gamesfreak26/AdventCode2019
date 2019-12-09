using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCalender.DayProblems.Day3
{
    public class Direction
    {

        public enum Directions
        {
            Up,
            Down,
            Left,
            Right
        }

        private Dictionary<string, (int, int)> _directions = new Dictionary<string, (int, int)>();

        public Dictionary<string, (int, int)> DirectionsList => _directions;

        public Direction() {
            _directions.Add("Up", (0, 1));
            _directions.Add("Down", (0, -1));
            _directions.Add("Left", (-1, 0));
            _directions.Add("Right", (1, 0));
        }

        public List<(int, int)> AddDirection(char direction, int adder)
        {

            var positions = new List<(int, int)>();
            var (x, y) = (0,0);
            for (var i = 0; i < adder; i++)
            {

                switch (direction)
                {
                    case 'U':
                    {
                        positions.Add((x, y + i));
                        break;
                    }


                    case 'D':
                    {
                        positions.Add((x, y - i));
                        break;
                    }

                    case 'L':
                    {
                        positions.Add((x - i, y));
                        break;
                    }

                    case 'R':
                    {
                        positions.Add((x + i, y));
                        break;
                    }
                }
            }
            
            return positions;
        }
    }
}
