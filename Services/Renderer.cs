using ASCII_Runner.DataStore;
using ASCII_Runner.Entities;
using ASCII_Runner.Services.ServiceTypes;

namespace ASCII_Runner.Services
{
    internal static class Renderer
    {
        private static bool SomeFlag { get; set; } = true;

        public static void Show(Arena arena)
        {
            if (SomeFlag)
            {
                for (int i = 0; i < arena.Field.Length; i++)
                {
                    for (int j = 0; j < arena.Field.Length; j++)
                    {
                        Console.Write(arena.Field[i][j].Symbol);
                    }

                    Console.WriteLine();
                }

                SomeFlag = false;
            }
        }
    }
}
