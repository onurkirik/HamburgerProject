using HamburgerProject.DATA;
using HamburgerProject.ENUMS;

namespace HamburgerProject.Models.ViewModels
{
    public class OrderCreateViewModel
    {
        public List<Menu> Menus { get; set; }
        public List<ExtraMaterial> ExtraMaterials { get; set; }
        public int OrderNumber { get; set; }
        public int MenuId { get; set; }
        public List<int> MaterialIds { get; set; }
        public Size Size { get; set; }
    }
}
