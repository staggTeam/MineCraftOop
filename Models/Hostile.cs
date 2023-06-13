using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oop_tamrin.Interfaces;

namespace Oop_tamrin.Models
{
    public class Hostile : IMob
    {
        public string Name { get ; set ; }
        public string Type { get ; set ; }
        public IMob Father { get ; set ; }
        public IMob Mother { get ; set ; }

        public IMob Breed(IMob mother)
        {
            var n = new Mob();
            n.Father = this;
            n.Mother = mother;
            return n;
            Console.WriteLine($"the {n} was born");
        }

        public void Hit(IMob mob)
        {
            System.Console.WriteLine($"the {this.Name} hitting {mob.Name}");
        }

        public void kill(IMob mob)
        {
            Console.WriteLine($"{mob.Name} was slain by {this.Name}");
        }

        public virtual void Show()
        {
             System.Console.WriteLine($"this is {this.Name}");
        }
    }
}