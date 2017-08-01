using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch04_03
{
    class Fish
    {
        /* Data members changed to private */
        string species;
        float weight, size;

        /* Constructor */
        public Fish(string species, float weight, float size)
        {
            this.species = species;
            this.weight = weight;
            this.size = size;
        }

        int Price()
        {
            return (int)Math.Round(weight * 7.25 / 100);
        }

        int Shipping()
        {
            return (int)Math.Round(weight * 0.02 + size * 0.1);
        }

        public override string ToString()
        {
            return string.Format(
                    species + "\t" +
                    weight + "\t\t" +
                    size + "\t\t" +
                    Price() + "\t" +
                    Shipping()
                );
        }
    }
}
