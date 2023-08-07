using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
     class VehicleFactory
    {
        public IVehicle CreateVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "car":
                    return new Car() {Color="Blue", IsDriveable=true};
                case "motorcycle":
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }
    }
}
