using ASCII_Runner.Entities;
using ASCII_Runner.Services.ServiceTypes;

namespace ASCII_Runner.DataStore
{
    internal static class Storage
    {
        private static List<BaseEntity> Entities { get; set; } = new List<BaseEntity>();
        public static void Add(BaseEntity entity)
        {
            Entities.Add(entity);
        }
        public static void Remove(BaseEntity entity)
        {
            Entities.Remove(entity);
        }
        public static BaseEntity? GetByCoordinates(Point point)
        {
            return Entities.FirstOrDefault(e => e.Coordinates.x == point.x && e.Coordinates.y == point.y);
        }
    }
}
