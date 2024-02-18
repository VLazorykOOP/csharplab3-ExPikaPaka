using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp.src {
    class Point {
        // Class fields
        protected int x;
        protected int y;
        protected int color;

        // Constructor
        public Point(int x = 0, int y = 0) {
            this.x = x;
            this.y = y;
            color = 0;
        }

        // Class methods
        public void PrintCoordinates() {
            Console.WriteLine($"Coordinates: ({x}, {y})");
        }

        public double CalculateDistanceToOrigin() {
            return Math.Sqrt(x * x + y * y);
        }

        public void Move(int x1, int y1) {
            x += x1;
            y += y1;
        }

        // Class properties
        public int X {
            get { return x; }
            set { x = value; }
        }

        public int Y {
            get { return y; }
            set { y = value; }
        }

        public int Color {
            get { return color; }
        }
    }
}
