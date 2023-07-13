// Программа принимает число и выводит таблицу кубов.
void Cube(int cub)
{
    int count = 1;
    while(count<= cub)
    {
        Console.WriteLine($"{count} - {count*count*count}");
        count++;
    }
}
Console.Write("Введите число: ");
int cub = Convert.ToInt32(Console.ReadLine());

Cube (cub);
