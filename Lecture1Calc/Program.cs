// napiš program, co načte dvě čísla a vypíše jejich součet, rozdíl, součin a podíl a další matematické operace
// napiš kód bez Program class a Main metody

double a, b;
Console.Write("Zadejte první číslo: ");
if (!double.TryParse(Console.ReadLine(), out a)) {
	Console.WriteLine("Neplatný vstup, program končí.");
	return;
}

Console.Write("Zadejte druhé číslo: ");
if (!double.TryParse(Console.ReadLine(), out b)) {
	Console.WriteLine("Neplatný vstup, program končí.");
	return;
}

Console.WriteLine("Součet: {0} + {1} = {2}", a, b, a + b);
Console.WriteLine("Rozdíl: {0} - {1} = {2}", a, b, a - b);
Console.WriteLine("Součin: {0} * {1} = {2}", a, b, a * b);

if (b != 0) {
	Console.WriteLine("Podíl: {0} / {1} = {2}", a, b, a / b);
	Console.WriteLine("Zbytek po dělení: {0} % {1} = {2}", a, b, a % b);
} else {
	Console.WriteLine("Podíl: dělení nulou není povoleno.");
	Console.WriteLine("Zbytek po dělení: dělení nulou není povoleno.");
}

// odkaz na dokumentaci: https://learn.microsoft.com/en-us/dotnet/api/system.math

Console.WriteLine("Mocnina: {0} ^ {1} = {2}", a, b, Math.Pow(a, b));

if (a >= 0) {
	Console.WriteLine("Odmocnina z prvního čísla: √{0} = {1}", a, Math.Sqrt(a));
} else {
	Console.WriteLine("Odmocnina z prvního čísla: √{0} není definována pro záporné číslo.", a);
}

if (b >= 0) {
	Console.WriteLine("Odmocnina z druhého čísla: √{0} = {1}", b, Math.Sqrt(b));
} else {
	Console.WriteLine("Odmocnina z druhého čísla: √{0} není definována pro záporné číslo.", b);
}

Console.WriteLine("Sinus prvního čísla: sin({0}) = {1}", a, Math.Sin(a));
Console.WriteLine("Sinus druhého čísla: sin({0}) = {1}", b, Math.Sin(b));
Console.WriteLine("Cosinus prvního čísla: cos({0}) = {1}", a, Math.Cos(a));
Console.WriteLine("Cosinus druhého čísla: cos({0}) = {1}", b, Math.Cos(b));
Console.WriteLine("Tangens prvního čísla: tan({0}) = {1}", a, Math.Tan(a));
Console.WriteLine("Tangens druhého čísla: tan({0}) = {1}", b, Math.Tan(b));