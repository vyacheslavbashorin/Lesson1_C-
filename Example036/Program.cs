Console.Write ("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32 (Console.ReadLine());
string stringNumber = Convert.ToString (threeDigitNumber);
Console.WriteLine("Вторая цифра этого числа -> "+stringNumber[1]);
