namespace HamburgerProject.DATA
{
    public class ExtraMaterial
    {
        public int Id { get; set; }
        public string MaterialName { get; set; } = null!;
        public double Price { get; set; }


        public List<Order>? Orders { get; set; }
    }
}
