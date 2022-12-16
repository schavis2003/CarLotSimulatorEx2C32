using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot //Create a CarLot class -----DONE
    {
        public CarLot()
        {
            CarLot.numberOfCars++;  // Ex2 for Static Keyword - Increment by 1 everytime a new car is created----DONE
            // ClassName.StaticMember
        }

        public static int numberOfCars = 0; // Ex2 for Static Keywork --- DONE

        //It should have at least one property: a List of cars-----DONE
        public List<Car> Cars = new List<Car>();
    }
}
