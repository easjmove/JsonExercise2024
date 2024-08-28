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

        public Car(string Brand, string Model, string Color, int mileage)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Color = Color;
            this.Mileage = mileage;
        }

        public override string ToString()
        {
            return $"Brand: {Brand} - Model: {Model} - " +
                $"Color: {Color} - Mileage: {Mileage}";
        }
    }
}
