using ASCII_Runner.DataStore;
using ASCII_Runner.Services.ServiceTypes;

namespace ASCII_Runner.Entities
{
    internal abstract class BaseEntity
    {
        public EntityType Type { get; set; }
        public char Symbol { get; set; }
        public Point Coordinates { get; set; }

        public BaseEntity(EntityType type, char symbol, Point coordinates)
        {
            Symbol = symbol;
            Type = type;
            Coordinates = coordinates;

            Storage.Add(this);
        }
    }
}
