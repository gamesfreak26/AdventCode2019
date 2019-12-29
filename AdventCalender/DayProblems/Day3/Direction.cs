using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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

        public List<(int, int)> FindPoints(List<(char, string)> wire)
        {
            var num = 0;
            var tupleDirectionNumber = 0;
            int x = 0;
            int y = 0;
            var tmp = (x, y);
            var positions = new List<(int, int)>();

            var direction = ' ';

            foreach (var point in wire) {
                if (int.TryParse(point.Item2, out num)) {
                    tupleDirectionNumber = num;
                }
                direction = point.Item1;

                switch (direction) {
                    case 'U': {
                        for (int i = 0; i < tupleDirectionNumber; i++)
                        {
                            tmp = (x, y + i);
                            positions.Add(tmp);
                        }
                        break;
                    }
                    case 'D': {
                        for (int i = 0; i < tupleDirectionNumber; i++) {
                            tmp = (x, y - i);
                            positions.Add(tmp);
                        }
                        break;
                    }
                    case 'L': {
                        for (int i = 0; i < tupleDirectionNumber; i++) {
                            tmp = (x - i, y);
                            positions.Add((x - i, y));
                        }
                        break;
                    }                    
                    case 'R': {
                        for (int i = 0; i < tupleDirectionNumber; i++) {
                            tmp = (x + i, y);
                            positions.Add((x - i, y));
                        }
                        break;
                    }
                }
            }

            return positions;
        }
    }
}
