int n;
n = Convert.ToInt32(Console.ReadLine());
if (n % 6 == 0 || n % 7 == 0)
{
    Console.WriteLine("выходной");
}
else
{
    Console.WriteLine("рабочий день");
}
