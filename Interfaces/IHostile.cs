using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oop_tamrin.Interfaces
{
    public interface IHostile : IAnimal
    {
        public string Name { get; set; }
            public string Type { get; set; }
            public IMob Father { get; set; }
            public IMob Mother { get; set; }
        public void kill(IMob mob)
        {
            Console.WriteLine($"{mob.Name} was slain by {this.Name}");
        }
        public void Hit(IMob mob)
        {
            System.Console.WriteLine($"the {this.Name} hitting {mob.Name}");
        }
    }
}