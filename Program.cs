Console.WriteLine("Enter the first number:");

if(!Int32 .TryParse(Console.ReadLine(), out var number1))
{
    Console.WriteLine("Invalid input. Please enter an integer.");
    return;
}

Console.WriteLine("Enter the second number:");

if(!Int32 .TryParse(Console.ReadLine(), out var number2))
{
    Console.WriteLine("Invalid input. Please enter an integer.");
    return;
}

Console.WriteLine("Enter the operator (&, |, ^):");
var operatorInput = Console.ReadLine();
if (operatorInput.Length != 1 || !"&|^".Contains(operatorInput))
{
    Console.WriteLine("Invalid operator. Please enter one of &, |, ^.");
    return;
}

int result = operatorInput[0] switch
{
    '&' => number1 & number2,
    '|' => number1 | number2,
    '^' => number1 ^ number2,
    _ => throw new InvalidOperationException("Unexpected operator")
};

Console.WriteLine("Result in decimal: {0}", result);
Console.WriteLine("Result in binary: {0}", Convert.ToString(result, 2));
Console.WriteLine("Result in hexadecimal: {0:X}", result);