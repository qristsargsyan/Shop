using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        public IEnumerable<Car> cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car{ name="Telsa", shortDesc="", longDesc="",img="",price=45000, isFavourite=true, available=true}
                };
            }
                
        }
        public IEnumerable<Car> getFavcars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
