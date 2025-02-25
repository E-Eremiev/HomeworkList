namespace _25._02._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.Write("Input index value = ");
            sbyte n = sbyte.Parse(Console.ReadLine());
            sbyte[] num = new sbyte[n];
            //Array values
            for (sbyte i = 0; i < num.Length; i++)
            {
                Console.Write($"num[{i}] = ");
                num[i] = sbyte.Parse(Console.ReadLine());
            }
            //Input
            Console.Write("bomb = ");
            sbyte bomb = sbyte.Parse(Console.ReadLine());
            Console.Write("power = ");
            sbyte power = sbyte.Parse(Console.ReadLine());
            //bomb power
            for (int i = bomb - power; i <= bomb + power; i++)
            {
                if (i >= 0 && i <= num.Length)
                {
                    num[i] = 0;
                }

            }
            //sum
            sbyte s = 0;
            for (sbyte i = 0; i < num.Length; i++)
            {
                s += num[i];
            }
            //Output(print)
            for (sbyte i = 0; i < num.Length; i++)
            {
                s += num[i];
            }
            Console.WriteLine("Explosion resoult: ");
            for (sbyte i = 0; i < num.Length; i++)
            {

                Console.Write($"{num[i]}, ");

            }
            Console.WriteLine("");
            Console.WriteLine($"Sum of \"survived\" numbers\n ={s}");

        }
    }
}

