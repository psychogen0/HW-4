Console.WriteLine("Enter first number");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Enter second number");
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Enter action you want to perform");
char action = char.Parse(Console.ReadLine());

int result = 0;

switch (action)
{
    case '+':
        result = firstNum + secondNum;
        break;
    case '-':
        result = firstNum - secondNum;
        break;
    case '*':
        result = firstNum * secondNum;
        break;
    case '/':
        result = firstNum / secondNum;
        break;
}
Console.WriteLine();
Console.WriteLine($"{firstNum} {action} {secondNum} = {result}");