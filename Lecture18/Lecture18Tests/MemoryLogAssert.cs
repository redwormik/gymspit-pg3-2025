namespace Lecture18Tests;


internal static class MemoryLogAssert
{
	public static void AssertLogs(object[][] expected, MemoryLog log)
	{
		object[][] actual = log.Logs;
		Assert.AreEqual(expected.Length, actual.Length);

		for (int i = 0; i < expected.Length; i++)
		{
			CollectionAssert.AreEqual(expected[i], actual[i]);
		}
	}
}
