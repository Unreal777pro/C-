//программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int Number = new Random().Next(1,100000);

if (Number < 100) Console.WriteLine(Number + "-> Третьей цифры нет");
else 
{
    int ThirdDigit = Number;

    while (ThirdDigit > 999) 
    {
        ThirdDigit = ThirdDigit/10;
    }
    
    Console.WriteLine(Number + "-> " + ThirdDigit%10);
}