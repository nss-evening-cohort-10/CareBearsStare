using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearsStare.Bears
{
    abstract class CareBearBase
    {
        public string Name { get; protected set; }
        public BearColor Color { get; protected set; }
        public string BellyBadge { get; protected set; }

        public abstract void Stare();

        public void Care(string humanToCareFor)
        {
            Console.WriteLine($"{Name} cares deeply for {humanToCareFor}.");
        }

        public virtual void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"{Name} runs over to {careBearToHug.Name} and squeezes them, pressing their {BellyBadge} and {careBearToHug.BellyBadge} together.");
        }
    }

}
