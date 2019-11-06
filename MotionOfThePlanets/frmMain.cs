using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MotionOfThePlanets
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;


            //StarPlanetCometSystem();
            TwoStarsSystemWithPlanet();
            TwoStarsSystemWithCrossingPlanet();
            //TwoStarsSystemRound();
            //TwoStarsSystem();
            //ThreeStarsSystem();
            //PlanetMoonSystem();
        }

        private PlanetarySystem _planetarySystem;

        private void timer_Tick(object sender, EventArgs e)
        {
            PlotPlanets();

            _planetarySystem.StepForward();
        }

        private void PlotPlanets()
        {
            Matrix cartesianCoordinatesTransformation = new Matrix();
            cartesianCoordinatesTransformation.Scale(1, 1, MatrixOrder.Append);
            cartesianCoordinatesTransformation.Translate(Width / 2f, Height / 2f, MatrixOrder.Append);
            using (Graphics g = CreateGraphics())
            {
                g.Transform = cartesianCoordinatesTransformation;
                foreach (Planet planet in _planetarySystem.Planets)
                {
                    double radius = Math.Pow(planet.Mass, 1 / 3d);
                    int size = (int) radius;
                    if (size < 3)
                        size = 3;

                    g.FillEllipse(new SolidBrush(planet.Color), (float)planet.Position.X - (float)radius / 2, (float)planet.Position.Y - (float)radius / 2, size, size);
                    Console.WriteLine(planet.Position);
                }
            }
        }


        private void StarPlanetCometSystem()
        {
            var planets = new Planet[3];
            planets[0] = new Planet()
            {
                Position = new Vector(0, 200),
                Mass = 100,
                Speed = new Vector(5000, 0),
                Color = Color.Blue
            };

            planets[1] = new Planet()
            {
                Position = new Vector(0, 0),
                Mass = 300,
                Speed = new Vector(-5000, 0),
                Color = Color.Brown
            };

            planets[2] = new Planet()
            {
                Position = new Vector(100, 50),
                Mass = 300000,
                Speed = new Vector(0, 0),
                Color = Color.Green
            };

            _planetarySystem = new PlanetarySystem(planets);
        }

        private void TwoStarsSystemRound()
        {
            var planets = new Planet[2];
            planets[0] = new Planet()
            {
                Position = new Vector(0, 200),
                Mass = 400,
                Speed = new Vector(100, 0),
                Color = Color.Blue
            };

            planets[1] = new Planet()
            {
                Position = new Vector(0, 0),
                Mass = 400,
                Speed = new Vector(-100, 0),
                Color = Color.Brown
            };

            _planetarySystem = new PlanetarySystem(planets);
            _planetarySystem.TimeStep = .01;
        }

        private void TwoStarsSystem()
        {
            var planets = new Planet[2];
            planets[0] = new Planet()
            {
                Position = new Vector(0, 200),
                Mass = 800,
                Speed = new Vector(100, 0),
                Color = Color.Blue
            };

            planets[1] = new Planet()
            {
                Position = new Vector(0, 0),
                Mass = 800,
                Speed = new Vector(-100, 0),
                Color = Color.Brown
            };

            _planetarySystem = new PlanetarySystem(planets);
            _planetarySystem.TimeStep = .01;
        }


        private void TwoStarsSystemWithPlanet()
        {
            var planets = new Planet[3];
            planets[0] = new Planet()
            {
                Position = new Vector(0, 140),
                Mass = 5000,
                Speed = new Vector(200, 0),
                Color = Color.Blue
            };

            planets[1] = new Planet()
            {
                Position = new Vector(0, 0),
                Mass = 5000,
                Speed = new Vector(-200, 0),
                Color = Color.Brown
            };

            planets[2] = new Planet()
            {
                Position = new Vector(-300, 0),
                Mass = 5,
                Speed = new Vector(0, 500),
                Color = Color.OrangeRed
            };

            _planetarySystem = new PlanetarySystem(planets);
            _planetarySystem.TimeStep = .002;
        }

        private void TwoStarsSystemWithCrossingPlanet()
        {
            var planets = new Planet[3];
            planets[0] = new Planet()
            {
                Position = new Vector(-100, 50),
                Mass = 200,
                Speed = new Vector(100, 0),
                Color = Color.Blue
            };

            planets[1] = new Planet()
            {
                Position = new Vector(-100, 0),
                Mass = 200,
                Speed = new Vector(-100, 0),
                Color = Color.Brown
            };

            planets[2] = new Planet()
            {
                Position = new Vector(200, 250),
                Mass = 1,
                Speed = new Vector(-120, 0),
                Color = Color.OrangeRed
            };

            _planetarySystem = new PlanetarySystem(planets);
            _planetarySystem.TimeStep = .01;
        }


        private void ThreeStarsSystem()
        {
            var planets = new Planet[3];
            planets[0] = new Planet()
            {
                Position = new Vector(0, 200),
                Mass = 500,
                Speed = new Vector(100, -33),
                Color = Color.Blue
            };

            planets[1] = new Planet()
            {
                Position = new Vector(0, 0),
                Mass = 500,
                Speed = new Vector(-100, 33),
                Color = Color.Brown
            };

            planets[2] = new Planet()
            {
                Position = new Vector(66, 66),
                Mass = 500,
                Speed = new Vector(0, -122),
                Color = Color.GreenYellow
            };

            _planetarySystem = new PlanetarySystem(planets);
            _planetarySystem.TimeStep = .01;
        }

        private void PlanetMoonSystem()
        {
            var planets = new Planet[2];
            planets[0] = new Planet()
            {
                Position = new Vector(0, 0),
                Mass = 8000,
                Speed = new Vector(40, 0),
                Color = Color.Blue
            };

            planets[1] = new Planet()
            {
                Position = new Vector(0, 50),
                Mass = 3,
                Speed = new Vector(800, 0),
                Color = Color.Brown
            };

            _planetarySystem = new PlanetarySystem(planets);
            _planetarySystem.TimeStep = .003;
        }

        private void btnSetTimer_Click(object sender, EventArgs e)
        {
            timer.Interval = int.Parse(numTimer.Text);
        }
    }
}
