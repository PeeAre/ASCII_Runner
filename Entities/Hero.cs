using ASCII_Runner.Services.ServiceTypes;

namespace ASCII_Runner.Entities
{
    internal class Hero : BaseEntity
    {
        public Hero(Point coordinates) : base(EntityType.Hero, '@', coordinates) { }
    }
}
