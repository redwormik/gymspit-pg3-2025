namespace Lecture15.Tests;

using Lecture15;


[TestClass]
public class AnimalTests
{
	[TestMethod]
	public void AnimalTest()
	{
		Animal rex = new Animal("dog", "Rex");
		Assert.AreEqual("dog", rex.Species);
		Assert.AreEqual("Rex", rex.Name);

		Animal garfield = new Animal("cat", "Garfield", "Garf");
		Assert.AreEqual("cat", garfield.Species);
		Assert.AreEqual("Garfield", garfield.Name);
		Assert.AreEqual("Garf", garfield.Nickname);

		garfield.Nickname = "Lasagne Eater";
		Assert.AreEqual("Lasagne Eater", garfield.Nickname);

		Assert.ThrowsException<ArgumentException>(() => new Animal("", "NoSpecies"));
	}


	[TestMethod]
	public void SpeakTest()
	{
		Animal rex = new Animal("dog", "Rex");
		Assert.AreEqual("Bark, bark!", rex.Speak());

		Animal garfield = new Animal("cat", "Garfield");
		Assert.AreEqual("Meow, meow.", garfield.Speak());

		Animal fox = new Animal("fox", "Foxy");
		Assert.AreEqual("What does the fox say?", fox.Speak());
	}


	[TestMethod]
	public void CallTest()
	{
		Animal rex = new Animal("dog", "Rex");
		Assert.IsTrue(rex.Call("Rex"));
		Assert.IsFalse(rex.Call("Max"));

		Animal garfield = new Animal("cat", "Garfield", "Garf");
		Assert.IsTrue(garfield.Call("Garfield"));
		Assert.IsTrue(garfield.Call("Garf"));
		Assert.IsFalse(garfield.Call("Max"));
	}
}