namespace Lecture18.Tests;

using Lecture18Tests;


[TestClass]
public class CharacterTests
{
	[TestMethod]
	public void CharacterTest()
	{

	}


	[TestMethod]
	public void ResetTest()
	{

	}


	[TestMethod]
	public void AttackTest()
	{

	}


	[TestMethod]
	public void HitHitTest()
	{
		Random random = new Random();
		MemoryLog log = new MemoryLog();
		Character source = new Character(new AI(random), "Source", 1, 0, 10, new Die(random, 1));
		Character target = new Character(new AI(random), "Target", 1, 0, 10, new Die(random, 1));

		Assert.IsTrue(target.Alive);
		Assert.AreEqual(1, target.HealthRatio);
		target.Hit(log, source, 10);
		Assert.IsFalse(target.Alive);
		Assert.AreEqual(0, target.HealthRatio);

		object[][] expected = [
			["AttackHit", source, target, 1],
		];
		MemoryLogAssert.AssertLogs(expected, log);
	}


	[TestMethod]
	public void HitMissTest()
	{
		Random random = new Random(0);
		MemoryLog log = new MemoryLog();
		Controller controller = new AI(random);
		Character source = new Character(controller, "Source", 1, 0, 10, new Die(random, 1));
		Character target = new Character(controller, "Target", 1, 0, 10, new Die(random, 1));

		Assert.IsTrue(target.Alive);
		Assert.AreEqual(1, target.HealthRatio);
		target.Hit(log, source, 9);
		Assert.IsTrue(target.Alive);
		Assert.AreEqual(1, target.HealthRatio);

		object[][] expected = [
			["AttackMiss", source, target],
		];
		MemoryLogAssert.AssertLogs(expected, log);
	}


	[TestMethod]
	public void WaitTest()
	{
		Random random = new Random(0);
	}


	[TestMethod]
	public void RollAttackTest()
	{
		Random random = new Random(0);
		Die d20 = new Die(random, 20);

		Controller controller = new AI(random);
		Character character = new Character(controller, "Character", 10, 2, 10, new Die(random, 1));

		int[] expected = [17, 19, 18];
		int[] actual = [
			character.RollAttack(d20),
			character.RollAttack(d20),
			character.RollAttack(d20),
		];
		CollectionAssert.AreEqual(expected, actual);
	}


	[TestMethod]
	public void RollDamageTest()
	{
		Random random = new Random(0);
		Die d6 = new Die(random, 6);

		Controller controller = new AI(random);
		Character character = new Character(controller, "Character", 10, -1, 10, d6);

		int[] expected = [4, 4, 4];
		int[] actual = [
			character.RollDamage(),
			character.RollDamage(),
			character.RollDamage(),
		];
		CollectionAssert.AreEqual(expected, actual);
	}
}