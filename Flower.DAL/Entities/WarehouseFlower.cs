namespace Task5_EF.Entities
{
    public class WarehouseFlower : FlowerCounter
    {
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
