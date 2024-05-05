using ASCII_Runner.Services.ServiceTypes;

namespace ASCII_Runner.Entities
{
    internal class Wall : BaseEntity
    {
        public Wall(Point coordinates) : base(EntityType.Wall, '*', coordinates) { }
    }
}
