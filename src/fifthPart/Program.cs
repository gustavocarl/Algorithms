float firstNumber, fifthPart;

Console.WriteLine("Insira um número: ");
firstNumber = float.Parse(Console.ReadLine()!);

fifthPart = firstNumber / 5;

Console.WriteLine($"A quinta parte de {firstNumber} é: {fifthPart}");