Console.WriteLine("A soma dos 5 primeiros inteiros positivos: ");
int sum = 1 + 2 + 3 + 4 + 5;
Console.WriteLine($"A soma dos primeiros 5 inteiros positivos é: {sum}");
Console.WriteLine();

Console.WriteLine("A idade média de Sara (23), Mark (19) e Fátima (31)");
decimal middleAges = Convert.ToDecimal((23 + 19 + 31) / 3);
Console.WriteLine($"A média das idades é: {middleAges}");
Console.WriteLine();

Console.WriteLine("O número de vezes que 73 cabe em 403");
int division = 403 / 73;
Console.WriteLine($"A quantidade de vezes que 73 cabe em 403 é {division}");
Console.WriteLine();

Console.WriteLine("2 à 10 potência: ");
double potentiation = Math.Pow(2, 10);
Console.WriteLine(potentiation);
Console.WriteLine();

Console.WriteLine("O valor absoluto da distância entre a altura de Sara (54 polegadas) e a altura de Mark (57 polegadas)");
int absoluteValue = Math.Abs((57 - 54));
Console.WriteLine($"O valor absoluto entre 57 e 54 é: {absoluteValue}");
Console.WriteLine();

Console.WriteLine("O menor preço entre os seguintes preços: R$ 34,99 R$ 29,95 e R$ 31.50");
double minValue = Math.Min(34.99, 29.95);
double minValue2 = Math.Min(minValue, 31.50);
Console.WriteLine(minValue2);