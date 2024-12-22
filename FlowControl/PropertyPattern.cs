
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Car
    {
        public string Model { get; set; }
        public DateTime ProducedAt { get; set; }
    }

    
    internal class PropertyPattern
    {
        static string GetNickname(Car car)
        {
            var GenerateMessage = (Car car, string nickName) =>
            $"{car.Model} Produced in {car.ProducedAt.Year} is {nickName}";

            if (car is Car { Model: "Mustang", ProducedAt.Year: 1967 })
                return GenerateMessage(car, "Fastback");
            else if (car is Car { Model: "Mustang", ProducedAt.Year: 1976 })
                return GenerateMessage(car, "Cobra ii");
            else
                return GenerateMessage(car, "UnKnown");
        }

    }
}
