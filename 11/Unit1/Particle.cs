using System;

namespace Task11
{
    public class Particle
    {
        public double weightOfParticle;
        private int particleSpeed = (int) Math.Pow(10, 6);

        public Particle()
        {
        }

        public Particle(double weight)
        {
            weightOfParticle = weight;
        }

        public double GetMetterWaveslengthOfParticle()
        {
            return (6.63 * Math.Pow(10, -34)) / (weightOfParticle * particleSpeed);
        }
    }
}