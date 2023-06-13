using Oop_tamrin.Interfaces;

namespace Oop_tamrin.Models
{
    internal class Mob : IMob
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public IMob Father { get; set; }
        public IMob Mother { get; set; }

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
        public void Show()
        {
            System.Console.WriteLine($"this is {this.Name}");
        }
        
    }
}