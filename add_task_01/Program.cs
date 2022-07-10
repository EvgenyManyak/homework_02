int h, a, b, s;
h = Convert.ToInt32(Console.ReadLine());
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
s = ((h - a) / (a - b) + 1);
Console.WriteLine(s);