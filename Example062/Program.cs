//Ввод числа с приглашением
int Prompt (string message)
{
    Console.Write (message);
    return int.Parse (Console.ReadLine ());
}
//Вычисление суммы цифр числа
int CalcSumdigits (int number)
{
    int sum = 0;
    while (number >0)
    {
    sum+=number%10;
    number=number/10;
    }
    return sum;
}
int number= Prompt ("Введите число: ");
int result = CalcSumdigits (number);
System.Console.WriteLine($"Сумма цифр равна {result}");  