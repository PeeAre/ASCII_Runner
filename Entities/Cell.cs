using ASCII_Runner.Services.ServiceTypes;

namespace ASCII_Runner.Entities
{
    internal class Cell : BaseEntity
    {
        public Cell(Point coordinates) : base(EntityType.Cell, ' ', coordinates) { }
    }
}
