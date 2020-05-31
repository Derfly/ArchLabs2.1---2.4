using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace BLL
{
    public class API
    {
        Dictionary<string, ChildZone> ChildZones = new Dictionary<string, ChildZone> ();

        

        public void CreateNewChildZone (ChildZone cafe)
        {
            ChildZones.Add (cafe.Name, cafe);
        }

        public bool Reserve (string NameCafe, int number)
        {
            return ChildZones [NameCafe].Reserve (number);
        }

        public ChildZone FindZone(string Name)
        {
            return ChildZones[Name];
        }

        public int getCountCZ()
        {
            return ChildZones.Count;
        }
    }
}
