using System;

namespace Lab
{
    public class Particle
    {
        private int size;
        private double price;
        private double scale;

        [ParticleInfo("double", "scale")]
        public double Scale
        {
            get { return scale; }
            set { scale = value; }
        }


        [ParticleInfo("int", "size")]
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        [ParticleInfo("double", "size")]
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        

    }
}
