using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    [DllImport("kernel32")]
    private static extern bool Beep(int freq, int duration);

    private static void Main(string[] args)
    {
        Random rand = new Random();


        
        for (int i = 0; i < 99; i++)
        {
            int x = rand.Next(200, 2000);
            int y = 1000;
            void print_bepp()
            {
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine($"Sound have frequency - {x} and duration - ${y}");
                    Thread.Sleep(y / 10);
                }
                Console.WriteLine("\n");
            }
            Thread thread = new Thread(print_bepp);
            thread.Start();
            Beep(x, y);
        }
    }
}