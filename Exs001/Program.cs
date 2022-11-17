Console.WriteLine("Введите натуральное число больше 1:");
int n= Convert.ToInt32(Console.ReadLine());
int count=1;
NaturalToLow(n, count);

void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write (count  + " ");
    }
}
