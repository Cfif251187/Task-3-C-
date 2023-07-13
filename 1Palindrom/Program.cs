// Программа проверяет, является ли число палиндромом.
bool Palindrome(int num)
{
   string number = num.ToString();
   for(int i = 0; i < number.Length/2; i++)
{
    if(number[i] != number[number.Length-i-1])
    {
        return false;
    }
}
return true;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Palindrome(number);
Console.WriteLine(result);