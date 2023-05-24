using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oop_tamrin.Interfaces;

namespace Oop_tamrin.Models
{
    public class Piglin : IMob, IHostile
    {
        public string Name  { get ; set ; }
        public string Type  { get ; set ; }
        public IMob Father { get ; set ; }
        public IMob Mother { get ; set ; }
        public void kill(IMob mob)
        {
            Console.WriteLine($"{mob.Name} was slain by {this.Name}");
        }
        public void Hit(IMob mob)
        {
            System.Console.WriteLine($"the {mob.Name} hitting {this.Name}");
        }
    }
}