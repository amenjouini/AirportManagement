using System.Numerics;

namespace AM.Core.Domain
{
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public IList<Flight> Flights { get; set; }

        public Plane(){ } // "ctor" to generate this constructor

        public Plane(PlaneType planetype, int capacity, DateTime manufacturedate) 
        {
            MyPlaneType = planetype;
            Capacity = capacity;
            ManufactureDate = manufacturedate;  
            
        }

        public override string ToString()
        {
            return "Capacity:" + Capacity + ";"
                + "ManufactureDate:" + ManufactureDate + ";"
                + "PlaneId:" + PlaneId + ";"
                ;
        }
    }
}
