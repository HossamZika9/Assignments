// If Satement


char sign;
float num1, num2, result;


Console.Write("Enter The Sign : ( + , - , / , * ) : ");
sign = Convert.ToChar(Console.ReadLine());

Console.Write("Enter First Number: ");
num1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter Second Number: ");
num2 = Convert.ToSingle(Console.ReadLine());

if (sign == '+')
{
    result = num1 + num2;
    Console.WriteLine($"{num1} + {num2} = {result}");
}

else if (sign == '-')
{
    result = num1 - num2;
    Console.WriteLine($"{num1} - {num2} = {result}");

}

else if (sign == '/' || sign == '÷')
{

    result = num1 / num2;
    Console.WriteLine($"{num1} / {num2} = {result}");

}

else if (sign == '*')
{

    result = num1 * num2;
    Console.WriteLine($"{num1} * {num2} = {result}");

}

else
{
    Console.WriteLine("Invalid sign!");
}
