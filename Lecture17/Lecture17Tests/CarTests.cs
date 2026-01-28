namespace Lecture17.Tests;

using Lecture17;


[TestClass]
public class CarTests
{
	[TestMethod]
	public void TankTest()
	{
		Car car = new Car(new Engine(100, 3.0 / 100), new GasTank(50));
		car.Tank(30);
		Assert.ThrowsException<ArgumentException>(() => car.Tank(25));
	}


	[TestMethod]
	public void GoTest()
	{
		Car car = new Car(new Engine(100, 3.0 / 100), new GasTank(50));
		car.Tank(30);

		StringWriter writer = new StringWriter();
		car.Go(100, writer);

		string expected = $"Went 100 km in 1 hours. 25 liters of gas left.{Environment.NewLine}";
		string actual = writer.ToString();
		Assert.AreEqual(expected, actual);

		writer.GetStringBuilder().Clear();
		car.Go(200, writer);

		expected = $"Went 200 km in 2 hours. 15 liters of gas left.{Environment.NewLine}";
		actual = writer.ToString();
		Assert.AreEqual(expected, actual);

		Assert.ThrowsException<ArgumentException>(() => car.Go(400, writer));
	}
}