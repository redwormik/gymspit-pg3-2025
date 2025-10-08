int length = 10;

// https://learn.microsoft.com/en-us/dotnet/api/system.array?view=net-9.0
int[] array = new int[length];
Random rnd = new Random(809045030);

for (int i = 0; i < array.Length; i += 1) {
	array[i] = rnd.Next(-1000, 1001);
}

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement
Console.WriteLine("Original array:");
foreach (int item in array) {
	Console.WriteLine(item);
}
Console.WriteLine();


int[] copy = new int[length];
// https://learn.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-9.0#system-array-copy(system-array-system-array-system-int32)
Array.Copy(array, copy, length - 1);
Console.WriteLine("Copied array (almost):");
foreach (int item in copy) {
	Console.WriteLine(item);
}
Console.WriteLine();


int mid = length / 2;
// https://learn.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-9.0#system-array-copy(system-array-system-int32-system-array-system-int32-system-int32)
Array.Copy(array, mid, copy, 0, length - mid);
Array.Copy(array, 0, copy, length - mid, mid);
Console.WriteLine("Copied array (cut and switch):");
for (int i = 0; i < length; i += 1) {
	Console.WriteLine("{0} {1}", array[i], copy[i]);
}
Console.WriteLine();

// https://learn.microsoft.com/en-us/dotnet/api/system.random.shuffle?view=net-9.0#system-random-shuffle-1(-0())
rnd.Shuffle(copy);
Console.WriteLine("Shuffled array:");
foreach (int item in copy) {
	Console.WriteLine(item);
}
Console.WriteLine();

// https://learn.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-9.0#system-array-sort(system-array)
Array.Sort(copy);
Console.WriteLine("Sorted array:");
foreach (int item in copy) {
	Console.WriteLine(item);
}
Console.WriteLine();

// Demonstrate Array.Sort with czech diacritics and upper / lower case
string[] strings = ["ábécé", "ábCé", "ábčé", "ábčÉ", "ábčd", "ábčD", "ábcd", "ábCd", "ábd"];
// default sort (system settings)
Array.Sort(strings);
// custom culture, case sensitivity
// Array.Sort(strings, StringComparer.Create(new System.Globalization.CultureInfo("en-US"), ignoreCase: false));
// sort by Unicode code points (ordinal)
// Array.Sort(strings, StringComparer.Ordinal);
Console.WriteLine("Sorted strings with Czech diacritics:");
foreach (string item in strings) {
	Console.WriteLine(item);
}
Console.WriteLine();

// https://learn.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-9.0#system-array-reverse(system-array)
Array.Reverse(copy);
Console.WriteLine("Reversed array:");
foreach (int item in copy) {
	Console.WriteLine(item);
}
Console.WriteLine();

// https://learn.microsoft.com/en-us/dotnet/api/system.array.clear?view=net-9.0#system-array-clear(system-array-system-int32-system-int32)
Array.Clear(copy, 4, 3);
// Array.Clear(copy); // clear whole array
Console.WriteLine("Cleared two elements in the middle of the array:");
foreach (int item in copy) {
	Console.WriteLine(item);
}
Console.WriteLine();

// https://learn.microsoft.com/en-us/dotnet/api/system.array.fill?view=net-9.0#system-array-fill-1(-0()-0-system-int32-system-int32)
Array.Fill(copy, 42, 6, 2);
// Array.Fill(copy, 42); // fill whole array
Console.WriteLine("Filled two elements in the middle of the array with 42:");
foreach (int item in copy) {
	Console.WriteLine(item);
}
Console.WriteLine();

// https://learn.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-9.0#system-array-indexof-1(-0()-0)
Console.WriteLine("Array.IndexOf(copy, 0) = {0}", Array.IndexOf(copy, 0));
Console.WriteLine("Array.IndexOf(copy, 474) = {0}", Array.IndexOf(copy, 474));
Console.WriteLine("Array.IndexOf(copy, -824) = {0}", Array.IndexOf(copy, -824));
Console.WriteLine("Array.IndexOf(copy, 666) = {0}", Array.IndexOf(copy, 666));
Console.WriteLine();

// https://learn.microsoft.com/en-us/dotnet/api/system.array.lastindexof?view=net-9.0#system-array-lastindexof-1(-0()-0)
Console.WriteLine("Array.LastIndexOf(copy, 0) = {0}", Array.LastIndexOf(copy, 0));
Console.WriteLine("Array.LastIndexOf(copy, 474) = {0}", Array.LastIndexOf(copy, 474));
Console.WriteLine("Array.LastIndexOf(copy, -824) = {0}", Array.LastIndexOf(copy, -824));
Console.WriteLine("Array.LastIndexOf(copy, 666) = {0}", Array.LastIndexOf(copy, 666));
Console.WriteLine();

// extension methods from System.Linq
// https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable?view=net-9.0
// (https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/working-with-linq)
// (https://learn.microsoft.com/en-us/dotnet/csharp/linq/)
int sum = array.Sum();
Console.WriteLine("Sum of all numbers: {0}", sum);
Console.WriteLine();

double average = array.Average();
Console.WriteLine("Average of all numbers: {0}", average);
Console.WriteLine();

int max = array.Max();
Console.WriteLine("Maximum value: {0}", max);
Console.WriteLine();

int min = array.Min();
Console.WriteLine("Minimum value: {0}", min);
Console.WriteLine();


// https://learn.microsoft.com/en-us/dotnet/api/system.array.resize?view=net-9.0#system-array-resize-1(-0()@-system-int32)
Array.Resize(ref copy, length * 2);
Console.WriteLine("Resized length: {0}", copy.Length);
Console.WriteLine("Resized copied array:");
foreach (int item in copy) {
	Console.WriteLine(item);
}
Console.WriteLine();

Array.Resize(ref copy, length / 2);
Console.WriteLine("Resized length: {0}", copy.Length);
Console.WriteLine("Resized copied array:");
foreach (int item in copy) {
	Console.WriteLine(item);
}
Console.WriteLine();

// resizing dynamically as needed
int initialLength = 1;
int count = 0;
string[] list = new string[initialLength];
string line;

Console.WriteLine("Enter strings, one per line (empty line to finish):");
line = Console.ReadLine();
while (line != "") {
	if (count == list.Length) {
		Console.WriteLine("Resizing from {0} to {1}!", list.Length, list.Length * 2);
		Array.Resize(ref list, list.Length * 2);
	}

	list[count] = line;
	count += 1;

	line = Console.ReadLine();
}

Array.Resize(ref list, count); // shorten to only have valid values
Array.Sort(list);
foreach (string item in list) {
	Console.WriteLine(item);
}
Console.WriteLine();
