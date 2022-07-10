int n;
n = Convert.ToInt32(Console.ReadLine());
if (n % 100 == n)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(Convert.ToString (n)[2]);
}
