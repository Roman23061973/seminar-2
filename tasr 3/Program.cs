Console.WriteLine("Введите номер дня недели (например:1-понедельник... 7-воскресенье):");
int number = Convert.ToInt32(Console.ReadLine());

if (namber<1 || namber>7)

{
    Console.WriteLine("Error. Введена неправильная цифра.");

}

else if (number>5)

{
    Console.WriteLine("Да, это выходной день.");

}

else (namber<6);

{

    Console.WriteLine("Нет, это не выходной.");
    
}  
    
    