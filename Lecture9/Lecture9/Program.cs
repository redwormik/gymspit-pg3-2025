namespace Lecture9;


public class Program
{
	public static void BubbleSort(int[] array)
	{
		int n = array.Length;
		for (int i = 0; i < n - 1; i++) {
			bool swapped = false;

			for (int j = 0; j < n - i - 1; j++) {
				if (array[j] > array[j + 1]) {
					// Swap array[j] and array[j+1]
					int temp = array[j];
					array[j] = array[j + 1];
					array[j + 1] = temp;
					swapped = true;
				}
			}

			if (!swapped) {
				break;
			}
		}
	}


	static void Main(string[] args)
	{
	}
}
