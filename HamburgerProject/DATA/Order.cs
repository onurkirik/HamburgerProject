using HamburgerProject.ENUMS;
using System.Security.Principal;

namespace HamburgerProject.DATA
{
    public class Order
    {
        public int Id { get; set; }
        public Size Size { get; set; }
        public int Number { get; set; }
        public double TotalPrice { get; set; }

        public List<ExtraMaterial> EkstraMaterials { get; set; }


        public int MenuId { get; set; }
        public Menu Menu { get; set; }

        public void CaltulatePrice()
        {
            TotalPrice = 0;
            TotalPrice += Menu.Price;

            if (Size == Size.Medium)
                TotalPrice += TotalPrice * 0.10;
            else if (Size == Size.Large)
                TotalPrice += TotalPrice * 0.25;

            foreach (var material in EkstraMaterials)
            {
                TotalPrice += material.Price;
            }

            TotalPrice *= Number;
        }
    }
}
