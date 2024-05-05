using ASCII_Runner.Entities;
using ASCII_Runner.Services;
using System.Text;

namespace ASCII_Runner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arena = new Arena();
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Renderer.Show(arena);
            }
        }
    }
}
