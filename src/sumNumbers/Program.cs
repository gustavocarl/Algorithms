int firstNumber, secondNumber, thirdNumber, sumOfNumbers;

Console.WriteLine("Insira o primeiro número: ");
firstNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Insira o segundo número: ");
secondNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Insira o terceiro número: ");
thirdNumber = int.Parse(Console.ReadLine()!);

sumOfNumbers = firstNumber + secondNumber + thirdNumber;

Console.WriteLine($"A soma dos números digitados é igual a: {sumOfNumbers}");
