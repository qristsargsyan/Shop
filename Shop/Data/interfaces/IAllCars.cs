using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.interfaces
{
    interface IAllCars
    {
        IEnumerable<Car> cars { get; }
        IEnumerable<Car> getFavcars { get; set; }
        Car getObjectCar(int carId);
    }
}
