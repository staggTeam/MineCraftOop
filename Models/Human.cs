using Oop_tamrin.Interfaces;

namespace Oop_tamrin.Models
{
    public class Human :IMob
    {
        
        public string Name { get ; set ; }
        public string Type { get ; set ; }
       
         public IMob Mother { get; set; }
        public IMob Father { get; set; }

        public Human Breed(Human mother)
        {   
            var n = new Human();
            n.Father = this;
            n.Mother = mother;
            return n;
        }
       public void kill(IMob mob)
        {
            Console.WriteLine($"{this.Name} kills {mob.Name}");
        }
    }
}