using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public IList<Flight> Flights { get; set; }

        //TP1 Question 8   (constructeur) 
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            this.Capacity = capacity;// on peut utiliser this. ou sans this (pour distinguer les noms)
            ManufactureDate = date;
            MyPlaneType = pt;
        }

        public override string ToString()
        {
            return "Capacity:" + Capacity + ";"
                + "ManufactureDate:" + ManufactureDate + ";"
                + "PlaneId:" + PlaneId + ";"
                + "PlaneType:" + MyPlaneType;
        }
        
    }
}

