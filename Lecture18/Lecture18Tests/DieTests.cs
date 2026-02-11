namespace Lecture18.Tests;

using Lecture18;


[TestClass]
public class DieTests
{
	[TestMethod]
	public void RollD6Test()
	{
		Random random = new Random(0);
		Die d6 = new Die(random, 6);
		Assert.AreEqual(5, d6.Roll());
		Assert.AreEqual(5, d6.Roll());
		Assert.AreEqual(5, d6.Roll());
		Assert.AreEqual(4, d6.Roll());
		Assert.AreEqual(2, d6.Roll());
		Assert.AreEqual(4, d6.Roll());
	}


	[TestMethod]
	public void RollD20Test()
	{
		Random random = new Random(0);
		Die d20 = new Die(random, 20);
		Assert.AreEqual(15, d20.Roll());
		Assert.AreEqual(17, d20.Roll());
		Assert.AreEqual(16, d20.Roll());
		Assert.AreEqual(12, d20.Roll());
		Assert.AreEqual(5, d20.Roll());
		Assert.AreEqual(12, d20.Roll());
	}


	[TestMethod]
	public void RollMultipleD6Test()
	{
		Random random = new Random(0);
		Die d6 = new Die(random, 6);
		Assert.AreEqual(19, d6.RollMultiple(4));
		Assert.AreEqual(6, d6.RollMultiple(2));
	}


	[TestMethod]
	public void RollMultipleD20Test()
	{
		Random random = new Random(0);
		Die d20 = new Die(random, 20);
		Assert.AreEqual(60, d20.RollMultiple(4));
		Assert.AreEqual(17, d20.RollMultiple(2));
	}
}