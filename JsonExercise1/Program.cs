using System.Text.Json;
using JsonExercise1.Models;

Car myCar = new Car("BMW", "330e", "Green", 45721);

Console.WriteLine("Step1");
Console.WriteLine(myCar);

string serializedCar = JsonSerializer.Serialize(myCar);

Console.WriteLine("Step2");
Console.WriteLine(serializedCar);

List<Car> cars = new List<Car>();
cars.Add(myCar);
cars.Add(new Car("Audi", "RS6", "Sort", 3035));

string jsonList =  JsonSerializer.Serialize(cars);
Console.WriteLine("Step3");
Console.WriteLine(jsonList);