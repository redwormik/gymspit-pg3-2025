namespace Lecture9.Tests;


[TestClass]
public sealed class BubbleSortTests
{
	[TestMethod]
	public void TestBubbleSort()
	{
		int[] array = { 64, 34, 25, 12, 22, 11, 90 };
		int[] expected = { 11, 12, 22, 25, 34, 64, 90 };
		Program.BubbleSort(array);
		CollectionAssert.AreEqual(expected, array);
	}
}
