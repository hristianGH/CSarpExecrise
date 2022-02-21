using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndCitrizen
{
    class Citizen :Interfaces.IPerson, Interfaces.IIdentifiable ,Interfaces.IBirthable
    {
        public Citizen(string n , int a,string id,string bD)
        {
            Name = n;
            Age = a;
            ID = id;
           // DateTime date = DateTime.ParseExact(bD,"dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture);
            BirthDate = bD;
            //dd/mm/yyyy
        }
        public string Name { get ; set; }
        public int Age { get; set; }
        public string ID { get; set; }
        public string BirthDate { get; set; }
    }
    
}
