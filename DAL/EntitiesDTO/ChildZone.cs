using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntitiesDTO
{
    public class ChildZone
    {
        public int Id { get; set; }

        public List<Attractions> attractions = new List<Attractions>();

        public List<Actors> actors = new List<Actors>();

        public int FreePlaces { get; set; }
        public int ReservedPlaces { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public ChildZone()
        {

        }

        public ChildZone(int Id, string Name, string Location, int FreePlaces)
        {
            this.Id = Id;
            this.Name = Name;
            this.Location = Location;
            this.FreePlaces = FreePlaces;
        }

        public bool Reserve(int number)
        {
            if (number < FreePlaces)
            {
                FreePlaces = FreePlaces - number;
                ReservedPlaces = number;
                return true;
            }
            else
                return false;
        }

        public void AddActor(string FName, string LName)
        {
            actors.Add(new Actors(FName, LName));
        }

        public void AddAttraction(String Name, int Price)
        {
            attractions.Add(new Attractions(Name, Price));
        }
    }
}
