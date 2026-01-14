namespace Lecture15;


public class Car
{
	private Engine engine;

	private GasTank gasTank;


	public Car(Engine engine, GasTank gasTank)
	{
		this.engine = engine;
		this.gasTank = gasTank;
	}


	public void Tank(double amount)
	{
		gasTank.Add(amount);
	}


	public void Go(double distance, TextWriter writer)
	{
		double time = engine.Run(distance, gasTank);
		writer.WriteLine("Went {0} km in {1} hours. {2} liters of gas left.", distance, time, gasTank.Amount);
	}
}
