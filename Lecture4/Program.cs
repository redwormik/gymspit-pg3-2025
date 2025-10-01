// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays
int[] myFirstArray = new int[10];

// pole se indexuje od 0
myFirstArray[0] = 2;
myFirstArray[1] = 8;
myFirstArray[2] = 32;
myFirstArray[3] = 9;
myFirstArray[4] = 3;
myFirstArray[5] = 14;
myFirstArray[6] = 7;
myFirstArray[7] = 314;
myFirstArray[8] = 256;
myFirstArray[9] = 84;
// myFirstArray[10] = 66; IndexOutOfRangeException

// prvek myFirstArray[myFirstArray.Length] neexistuje
// při přístupu k neexistujícímu prvku dostanu IndexOutOfRangeException
for (int i = 0; i < myFirstArray.Length; i += 1) {
	Console.WriteLine(myFirstArray[i]);
}
Console.WriteLine();

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/collection-expressions
int[] mySecondArray = [-51, 82, 39, 64, 78, -63, -85, 97, 82, -37];
for (int i = 0; i < mySecondArray.Length; i += 1) {
	Console.WriteLine(mySecondArray[i]);
}
Console.WriteLine();


int size;
bool success;
do {
	Console.Write("Please enter the length of the array: ");
	success = int.TryParse(Console.ReadLine(), out size) && size >= 0;
	if (!success) {
		Console.WriteLine("That is not a valid length!");
	}
} while (!success);

int[] variableArray = new int[size];

Console.WriteLine("Length of the array is: {0}", variableArray.Length);

for (int i = 0; i < variableArray.Length; i += 1) {
	variableArray[i] = (int) Math.Round(Math.Sin(i * Math.PI / 12) * 100);
}

for (int i = 0; i < variableArray.Length; i += 1) {
	Console.WriteLine("{0} {1}", i, variableArray[i]);
}
Console.WriteLine();


if (variableArray.Length > 6) {
	// pole jsou reference types

	int[] anotherArray = variableArray;

	Console.WriteLine("Before:", 6, anotherArray[6]);
	Console.WriteLine("variableArray[{0}] = {1}", 6, variableArray[6]); // 100
	Console.WriteLine("anotherArray[{0}] = {1}", 6, anotherArray[6]); // 100

	anotherArray[6] = 24;

	Console.WriteLine("After:");
	Console.WriteLine("variableArray[{0}] = {1}", 6, variableArray[6]); // 24
	Console.WriteLine("anotherArray[{0}] = {1}", 6, anotherArray[6]); // 24

	Console.WriteLine();
}


// Objekt typu Random je generátor náhodných čísel
// Zavolání metody Next vrátí "náhodné" číslo
// Random generuje čísla pomocí vzorců, do kterých vstupují např. čas systému
https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-9.0
Random rnd = new Random();

// Random můžu inicializovat s tzv. seedem, pak vrací stejnou sekvenci hodnot
// Random rnd = new Random(1024);

Console.WriteLine(rnd.Next()); // 0 <= rnd.Next() < int.MaxValue
Console.WriteLine(rnd.Next(1000)); // 0 <= rnd.Next(1000) < 1000
								   // rnd.Next(0) == 0
								   // rnd.Next(-1) vyhodí výjimku
Console.WriteLine(rnd.Next(10, 25)); // 10 <= rnd.Next(10, 25) < 25
									 // rnd.Next(10, 10) == 10
									 // rnd.Next(10, 9) vyhodí výjimku
Console.WriteLine();

for (int i = 0; i < variableArray.Length; i += 1) {
	variableArray[i] = rnd.Next(-10000, 10000);
}

for (int i = 0; i < variableArray.Length; i += 1) {
	Console.WriteLine("{0} {1}", i, variableArray[i]);
}
Console.WriteLine();


int min = int.MaxValue; // nebo variableArray[0]
int max = int.MinValue; // nebo variableArray[0]
int sum = 0;

for (int i = 0; i < variableArray.Length; i += 1) {
	if (variableArray[i] < min) {
		min = variableArray[i];
	}

	if (variableArray[i] > max) {
		max = variableArray[i];
	}

	sum += variableArray[i];
}

Console.WriteLine("Min: {0}", min);
Console.WriteLine("Max: {0}", max);
Console.WriteLine("Sum: {0}", sum);
Console.WriteLine("Avg: {0}", (double) sum / variableArray.Length);
Console.WriteLine();