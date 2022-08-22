/* Console.WriteLine("Введите число, которое хотите возвести в степень");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую хотите возвести число");
int DeegreOfNumber = Convert.ToInt32(Console.ReadLine());
double result = Math.Pow(Number, DeegreOfNumber);
Console.WriteLine(result); */

/*
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int s = 0;
while(n!=0)
{
s = s + n % 10;
n = n / 10;
}
Console.WriteLine("Сумма цифр в числе равна " + s);
    */


Console.WriteLine("Введите число элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Random rand = new Random();
for (int i = 0; i < N; i++)
{
   array[i] = rand.Next(1, 21);
}

for (int i = 0; i < N; i++)
{
    Console.WriteLine(array[i]);
}