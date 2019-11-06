using System.Collections.Generic;

namespace MotionOfThePlanets
{
    public class PlanetarySystem
    {
        public double TimeStep { get; set; } = .001;
        public double G { get; set; }= 10000;


        public PlanetarySystem(IEnumerable<Planet> planets)
        {
            Planets = planets;
        }

        public IEnumerable<Planet> Planets { get; }

        public void StepForward()
        {
            MovePlanets();
            CalculateForceOnAllPlanets();
            CalculatePlanetsSpeed();
        }

        /// <summary>
        /// Moves the planets (calculates new planets position)
        /// </summary>
        private void MovePlanets()
        {
            foreach (Planet planet in Planets)
            {
                planet.Position = planet.Position + planet.Speed * TimeStep;
            }
        }

        private void CalculatePlanetsSpeed()
        {
            foreach (Planet planet in Planets)
            {
                Vector acceleration = planet.Force / planet.Mass;
                planet.Speed = planet.Speed + acceleration * TimeStep;
            }
        }

        private void CalculateForceOnAllPlanets()
        {
            foreach (Planet planet in Planets)
            {
                Vector force = new Vector();
                foreach (Planet otherPlanet in Planets)
                {
                    // Un pianeta non ha effetto su se stesso
                    if (planet == otherPlanet)
                        continue;

                    force += CalculateForce(otherPlanet, planet);
                }

                planet.Force = force;
            }
        }

        public Vector CalculateForce(Planet from, Planet to)
        {
            Vector distanceVector = to.Position - from.Position;
            double moduleF = G * (from.Mass * to.Mass) / (distanceVector.Module() * distanceVector.Module());
            return new Vector(- moduleF / distanceVector.Module() * distanceVector.X, - moduleF / distanceVector.Module() * distanceVector.Y);
        }
    }
}