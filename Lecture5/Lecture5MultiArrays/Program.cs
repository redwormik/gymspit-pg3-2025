Random rnd = new Random(809045031);

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays#multidimensional-arrays
// multidimensional array - more indexes, elements are int
int width = 6;
int height = 4;
int[,] matrixA = new int[width, height];
int[,] matrixB = new int[width, height];
int[,] matrixSum = new int[width, height];

for (int y = 0; y < matrixA.GetLength(1); y += 1) {
	for (int x = 0; x < matrixA.GetLength(0); x += 1) {
		matrixA[x, y] = rnd.Next(-9, 10);
	}
}

for (int y = 0; y < matrixB.GetLength(1); y += 1) {
	for (int x = 0; x < matrixB.GetLength(0); x += 1) {
		matrixB[x, y] = rnd.Next(-9, 10);
	}
}

Console.WriteLine("Matrix A rank: {0}", matrixA.Rank);
Console.WriteLine("Matrix A length: {0}", matrixA.Length);
for (int dimension = 0; dimension < matrixA.Rank; dimension += 1) {
	Console.WriteLine("Matrix A dimension {0} length: {1}", dimension, matrixA.GetLength(dimension));
}
Console.WriteLine("Matrix A (foreach):");
foreach (int item in matrixA) {
	Console.Write("{0} ", item);
}
Console.WriteLine("\n");

Console.WriteLine("Matrix A:");
for (int y = 0; y < matrixA.GetLength(1); y += 1) {
	for (int x = 0; x < matrixA.GetLength(0); x += 1) {
		Console.Write("{0} ", matrixA[x, y]);
	}
	Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Matrix B:");
for (int y = 0; y < matrixB.GetLength(1); y += 1) {
	for (int x = 0; x < matrixB.GetLength(0); x += 1) {
		Console.Write("{0} ", matrixB[x, y]);
	}
	Console.WriteLine();
}
Console.WriteLine();


for (int y = 0; y < matrixSum.GetLength(1); y += 1) {
	for (int x = 0; x < matrixSum.GetLength(0); x += 1) {
		matrixSum[x, y] = matrixA[x, y] + matrixB[x, y];
	}
}

Console.WriteLine("Matrix sum:");
for (int y = 0; y < matrixSum.GetLength(1); y += 1) {
	for (int x = 0; x < matrixSum.GetLength(0); x += 1) {
		Console.Write("{0} ", matrixSum[x, y]);
	}
	Console.WriteLine();
}
Console.WriteLine();


// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays#jagged-arrays
// jagged array - array of arrays, elements are int[]
int[][] jaggedArray = new int[5][];
// more dimensions:
// int[][][] jaggedArray = new int[5][][];
for (int i = 0; i < jaggedArray.Length; i += 1) {
	jaggedArray[i] = new int[4];
	for (int j = 0; j < jaggedArray[i].Length; j += 1) {
		jaggedArray[i][j] = rnd.Next(0, 10);
	}
}

Console.WriteLine("Jagged array:");
for (int i = 0; i < jaggedArray.Length; i += 1) {
	for (int j = 0; j < jaggedArray[i].Length; j += 1) {
		Console.Write("{0} ", jaggedArray[i][j]);
	}
	Console.WriteLine();
}
Console.WriteLine();


for (int i = 0; i < jaggedArray.Length; i += 1) {
	jaggedArray[i] = new int[i + 1];
	for (int j = 0; j < jaggedArray[i].Length; j += 1) {
		jaggedArray[i][j] = rnd.Next(0, 10);
	}
}

Console.WriteLine("Jagged array with different lengths:");
for (int i = 0; i < jaggedArray.Length; i += 1) {
	for (int j = 0; j < jaggedArray[i].Length; j += 1) {
		Console.Write("{0} ", jaggedArray[i][j]);
	}
	Console.WriteLine();
}
Console.WriteLine();