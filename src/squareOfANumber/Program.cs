float firstNumber, squareOfANumber;

Console.WriteLine("Insira um número: ");
firstNumber = float.Parse(Console.ReadLine()!);

squareOfANumber = firstNumber * firstNumber;

Console.WriteLine($"O quadrado de {firstNumber} é igual a: {squareOfANumber}");
