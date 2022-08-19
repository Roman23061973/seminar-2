// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine('Ведите число:');
int number = Convert.ToInt32(Console.ReadLine());
char[]arr = number.ToString().ToGharArray();

if (namber>=100)

{

    Console.WriteLine($"Третья цифра этого чисда - {arr[2]}" );

}

else
{
    Console.WriteLine($"Error. Еретьей цифры нет: введите трехзнвчное число.");
}