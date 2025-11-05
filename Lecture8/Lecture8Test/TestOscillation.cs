namespace Lecture8Test;

using Lecture8;


[TestClass]
public class TestOscillation
{
	[TestMethod]
	public void TestMassOscillationAtZero()
	{
		double amplitude = 10.0E-2; // m
		double period = 2.0; // s
		double time = 0.0; // s

		double position = Program.OscillationPosition(amplitude, period, time);
		Assert.AreEqual(0.0, position, 0.0005);

		double velocity = Program.OscillationVelocity(amplitude, period, time);
		Assert.AreEqual(0.314, velocity, 0.0005);

		double acceleration = Program.OscillationAcceleration(amplitude, period, time);
		Assert.AreEqual(0.0, acceleration, 0.0005);
	}


	[TestMethod]
	public void TestMassOscillationAtQuarterPeriod()
	{
		double amplitude = 10.0E-2; // m
		double period = 2.0; // s
		double time = period / 4;

		double position = Program.OscillationPosition(amplitude, period, time);
		Assert.AreEqual(10.0E-2, position, 0.0005);

		double velocity = Program.OscillationVelocity(amplitude, period, time);
		Assert.AreEqual(0.0, velocity, 0.0005);

		double acceleration = Program.OscillationAcceleration(amplitude, period, time);
		Assert.AreEqual(-0.987, acceleration, 0.0005);
	}


	[TestMethod]
	public void TestMassOscillationAtHalfPeriod()
	{
		double amplitude = 10.0E-2; // m
		double period = 2.0; // s
		double time = period / 2;

		double position = Program.OscillationPosition(amplitude, period, time);
		Assert.AreEqual(0.0, position, 0.0005);

		double velocity = Program.OscillationVelocity(amplitude, period, time);
		Assert.AreEqual(-0.314, velocity, 0.0005);

		double acceleration = Program.OscillationAcceleration(amplitude, period, time);
		Assert.AreEqual(0.0, acceleration, 0.0005);
	}


	[TestMethod]
	public void TestMassOscillationAtPeriod()
	{
		double amplitude = 10.0E-2; // m
		double period = 2.0; // s
		double time = period;

		double position = Program.OscillationPosition(amplitude, period, time);
		Assert.AreEqual(0.0, position, 0.0005);

		double velocity = Program.OscillationVelocity(amplitude, period, time);
		Assert.AreEqual(0.314, velocity, 0.0005);

		double acceleration = Program.OscillationAcceleration(amplitude, period, time);
		Assert.AreEqual(0.0, acceleration, 0.0005);
	}


	[TestMethod]
	public void TestMassOscillation()
	{
		double amplitude = 10.0E-2; // m
		double period = 2.0; // s
		double time = 0.2; // s

		double position = Program.OscillationPosition(amplitude, period, time);
		Assert.AreEqual(5.9E-2, position, 0.0005);

		double velocity = Program.OscillationVelocity(amplitude, period, time);
		Assert.AreEqual(25.4E-2, velocity, 0.0005);

		double acceleration = Program.OscillationAcceleration(amplitude, period, time);
		Assert.AreEqual(-0.58, acceleration, 0.0005);
	}
}
