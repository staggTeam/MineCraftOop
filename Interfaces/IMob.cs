using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oop_tamrin.Models;

namespace Oop_tamrin.Interfaces
{
    public interface IMob 
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public IMob Father { get; set; }
        public IMob Mother { get; set; }

        public void Hit(IMob mob)
        {
            System.Console.WriteLine($"the {this.Name} hitting {mob.Name}");
        }

        public IMob Breed(IMob mother)
        {
            var n = new Human();
            n.Father = (Human)this;
            n.Mother = (Human)mother;
            return n;
        }


    }
}
