using System;
using System.Drawing;

namespace MotionOfThePlanets
{
    public class Planet
    {
        public string Name { get; set; }
        public Vector Speed { get; set; }
        public double Mass { get; set; }
        public Vector Position { get; set; }

        /// <summary>
        /// Gets or sets the forza applicata ad un pianeta in un determinato istante
        /// </summary>
        /// <value>
        /// The forza.
        /// </value>
        public Vector Force { get; set; }

        public Color Color { get; set; }
        public Vector Acceleration { get; set; }
    }
}
