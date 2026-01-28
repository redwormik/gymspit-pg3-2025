using Lecture17;

// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/base
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override
// (https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new-modifier)

Car car = new Car(new Engine(150, 5.0 / 100), new GasTank(40.0));
car.Tank(40.0);
car.Go(500, Console.Out);

Truck truck = new Truck(new Engine(120, 8.0 / 100), new GasTank(80.0), 20.0);
truck.Tank(80.0);
truck.Load(20.0);
truck.Go(500, Console.Out);
truck.Unload(20.0);

Console.WriteLine("car is Car: {0}", car is Car);
Console.WriteLine("car is Truck: {0}", car is Truck);
Console.WriteLine("truck is Car: {0}", truck is Car);
Console.WriteLine("truck is Truck: {0}", truck is Truck);

Car[] fleet = [car, truck];
foreach (Car fleetCar in fleet) {
	// fleetCar.Load(20);
	if (fleetCar is Truck fleetTruck) {
		fleetTruck.Load(20);
	}

	fleetCar.Tank(25.0);
	fleetCar.Go(250, Console.Out);
}