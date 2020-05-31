using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntitiesDTO
{
    public class Attractions
    {
        public string Name { get; }

        public int Price { get; set; }

        public bool Free { get; private set; }

        public Attractions(string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
            Free = true;
        }

        public void Play()
        {
            Free = false;
        }

        public void unPlay()
        {
            Free = true;
        }

    }
}
