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

        void Hit(IMob mob);
        IMob Breed(IMob mother);
        void Show ();
    }
}
