using Oop_tamrin.Interfaces;

namespace Oop_tamrin.Models
{
    public class Human : IMob
    {

        // public string Name { get; set; }
        // public string Type { get; set; }

        // public IMob Mother { get; set; }
        // public IMob Father { get; set; }

        // public Human Breed(Human mother)
        // {
        //     var n = new Human();
        //     n.Father = this;
        //     n.Mother = mother;
        //     return n;
        // }

        // public void Hit(IMob mob)
        // {
        //     System.Console.WriteLine($"the {this.Name} hitting {mob.Name}");
        // }

        // public void kill(IMob mob)
        // {
        //     Console.WriteLine($"{this.Name} kills {mob.Name}");
        // }
        public string Name { get ; set ; }
        public string Type { get ; set ; }
        public IMob Father { get ; set ; }
        public IMob Mother { get ; set ; }

        public IMob Breed(IMob mother)
        {
            throw new NotImplementedException();
        }

        public void Hit(IMob mob)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}