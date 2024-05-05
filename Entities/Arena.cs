using ASCII_Runner.Services.ServiceTypes;

namespace ASCII_Runner.Entities
{
    internal class Arena
    {
        public BaseEntity[][] Field { get; set; } = new BaseEntity[FieldSize][];
        public const int FieldSize = 9;

        public Arena()
        {
            int counter = 1;

            for (int i = 0; i < FieldSize; i++)
            {
                int[] line = new int[FieldSize];

                // generation algorithm start
                for (int j = 1; j < FieldSize; j += 2)
                {
                    line[j] = -1;
                }

                if (i % 2 == 1)
                {
                    for (int j = 1; j < FieldSize; j += 2, counter++)
                    {
                        line[j] = counter;
                    }
                }
                // generation algorithm end

                Field[i] = new BaseEntity[FieldSize];

                for (int k = 0; k < FieldSize; k++)
                {
                    if (line[k] == -1)
                    {
                        Field[i][k] = new Wall(new Point(i, k));
                    }
                    else
                    {
                        Field[i][k] = new Cell(new Point(i, k));
                    }
                }
            }
        }
    }
}
