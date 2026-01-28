namespace Lecture17;


public class Truck : Car
{
	private double capacity;
	private double loadAmount = 0.0;


	public Truck(Engine engine, GasTank gasTank, double capacity) :
		base(engine, gasTank)
	{
		this.capacity = capacity;
	}


	public override double LitersPerKm => 3.0 / 100 + loadAmount / 1000;


	public double LoadAmount => loadAmount;

	/*
	public double LoadAmount {
		get => loadAmount;
	}
	*/

	/*
	public double LoadAmount {
		get {
			return loadAmount;
		}
	}
	*/


	public override void Go(double distance, TextWriter writer)
	{
		base.Go(distance, writer);
		writer.WriteLine("Transported {0} stuff.", loadAmount);
	}


	public void Load(double amount)
	{
		if (amount + loadAmount > capacity) {
			throw new ArgumentException();
		}
		loadAmount += amount;
	}


	public void Unload(double amount)
	{
		if (amount > loadAmount) {
			throw new ArgumentException();
		}
		loadAmount -= amount;
	}
}
