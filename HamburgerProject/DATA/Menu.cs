namespace HamburgerProject.DATA
{
    public class Menu
    {
        public int Id { get; set; }
        public string MenuName { get; set; } = null!;
        public double Price { get; set; }

        public List<Order> Orders { get; set; }
    }
}
