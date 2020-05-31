using DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EntitiesDTO;

namespace UserInterface
{
    class DBCon
    {
        void TowardDataBase (ChildZone zone)
        {
            using (Context db = new Context ())
            {
                db.ZonesList.Add (zone);
                db.SaveChanges ();
            }
        }
    }
}
