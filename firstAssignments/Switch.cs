// Switch


char sign;
float num1, num2, result;


Console.Write("Enter The Sign : ( + , - , / , * ) : ");
sign = Convert.ToChar(Console.ReadLine());

Console.Write("Enter First Number: ");
num1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter Second Number: ");
num2 = Convert.ToSingle(Console.ReadLine());


switch(sign)
    {

    case '+':

        result = num1 + num2;
        break;


    case '-':
        result = num1 - num2;
        break;



    case '/':
        result = num1 / num2;
        break;


    case '*':
        result = num1 * num2;
        break;


    default:
        Console.WriteLine("Invalid sign!");
        break;

}

Console.WriteLine($"{num1} {sign} {num2} = {result}");