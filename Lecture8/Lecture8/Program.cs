namespace Lecture8;


public class Program
{
	public static double SerialCapacitors(double[] capacitances)
	{
		double reciprocalSum = 0.0;
		foreach (double c in capacitances)
		{
			reciprocalSum += 1.0 / c;
		}
		return 1.0 / reciprocalSum;
	}


	public static double ParallelCapacitors(double[] capacitances)
	{
		double sum = 0.0;
		foreach (double c in capacitances)
		{
			sum += c;
		}
		return sum;
	}


	public static double OscillationPosition(double amplitude, double period, double time)
	{
		double omega = 2.0 * Math.PI / period;
		return amplitude * Math.Sin(omega * time);
	}


	public static double OscillationVelocity(double amplitude, double period, double time)
	{
		double omega = 2.0 * Math.PI / period;
		return amplitude * omega * Math.Cos(omega * time);
	}


	public static double OscillationAcceleration(double amplitude, double period, double time)
	{
		double omega = 2.0 * Math.PI / period;
		return -amplitude * omega * omega * Math.Sin(omega * time);
	}


	private static void Main(string[] args)
	{
	}
}