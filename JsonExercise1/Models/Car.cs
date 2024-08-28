using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExercise1.Models
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }

        public Car()
        {
            
        }

        public Car(string Brand, string Model, string Color, int Mileage)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Color = Color;
            this.Mileage = Mileage;
        }

        public override string ToString()
        {
            return $"Brand: {Brand} - Model: {Model} - " +
                $"Color: {Color} - Mileage: {Mileage}";
        }
    }
}
