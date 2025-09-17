// napiš program, který se zeptá uživatele na přídavné jméno, zvíře, barvu, sloveso a vypíše větu
Console.Write("Zadejte přídavné jméno: ");
string pridavneJmeno = Console.ReadLine();

Console.Write("Zadejte zvíře: ");
string zvire = Console.ReadLine();

Console.Write("Zadejte barvu: ");
string barva = Console.ReadLine();

Console.Write("Zadejte sloveso: ");
string sloveso = Console.ReadLine();

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
string veta = $"Viděl jsem {pridavneJmeno} {zvire} v {barva} barvě, jak {sloveso}.";
Console.WriteLine(veta);

// vypiš větu přes klasický formátovaný řetězec
Console.WriteLine("Viděl jsem {0} {1} v {2} barvě, jak {3}.", pridavneJmeno, zvire, barva, sloveso);
