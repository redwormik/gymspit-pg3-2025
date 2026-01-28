using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lecture17;

namespace Lecture17.Tests;

using Lecture17;


[TestClass]
public class TruckTests
{
	[TestMethod]
	public void TankTest()
	{
		Truck truck = new Truck(new Engine(100, 3.0 / 100), new GasTank(50), 20.0);
		truck.Tank(30);
		Assert.ThrowsException<ArgumentException>(() => truck.Tank(25));
	}


	[TestMethod]
	public void GoTest()
	{
		Truck truck = new Truck(new Engine(100, 3.0 / 100), new GasTank(50), 20.0);
		truck.Tank(30);

		StringWriter writer = new StringWriter();
		truck.Go(100, writer);

		string expected = $"Went 100 km in 1 hours. 24 liters of gas left.{Environment.NewLine}Transported 0 stuff.{Environment.NewLine}";
		string actual = writer.ToString();
		Assert.AreEqual(expected, actual);

		writer.GetStringBuilder().Clear();
		truck.Go(200, writer);

		expected = $"Went 200 km in 2 hours. 12 liters of gas left.{Environment.NewLine}Transported 0 stuff.{Environment.NewLine}";
		actual = writer.ToString();
		Assert.AreEqual(expected, actual);

		Assert.ThrowsException<ArgumentException>(() => truck.Go(400, writer));
	}


	[TestMethod]
	public void GoAsCarTest()
	{
		Car car = new Truck(new Engine(100, 3.0 / 100), new GasTank(50), 20.0);
		car.Tank(30);

		StringWriter writer = new StringWriter();
		car.Go(100, writer);

		string expected = $"Went 100 km in 1 hours. 24 liters of gas left.{Environment.NewLine}Transported 0 stuff.{Environment.NewLine}";
		string actual = writer.ToString();
		Assert.AreEqual(expected, actual);

		writer.GetStringBuilder().Clear();
		car.Go(200, writer);

		expected = $"Went 200 km in 2 hours. 12 liters of gas left.{Environment.NewLine}Transported 0 stuff.{Environment.NewLine}";
		actual = writer.ToString();
		Assert.AreEqual(expected, actual);

		Assert.ThrowsException<ArgumentException>(() => car.Go(400, writer));
	}


	[TestMethod]
	public void LoadTest()
	{
		Truck truck = new Truck(new Engine(100, 3.0 / 100), new GasTank(50), 20.0);
		truck.Load(15.0);
		Assert.ThrowsException<ArgumentException>(() => truck.Load(10.0));
	}


	[TestMethod]
	public void LoadAndGoTest()
	{
		Truck truck = new Truck(new Engine(100, 3.0 / 100), new GasTank(50), 20.0);
		truck.Tank(30);
		truck.Load(10.0);

		StringWriter writer = new StringWriter();
		truck.Go(100, writer);

		string expected = $"Went 100 km in 1 hours. 23 liters of gas left.{Environment.NewLine}Transported 10 stuff.{Environment.NewLine}";
		string actual = writer.ToString();
		Assert.AreEqual(expected, actual);
	}


	[TestMethod]
	public void UnloadTest()
	{
		Truck truck = new Truck(new Engine(100, 3.0 / 100), new GasTank(50), 20.0);
		truck.Load(15.0);
		truck.Unload(10.0);
		Assert.ThrowsException<ArgumentException>(() => truck.Unload(10.0));
	}
}