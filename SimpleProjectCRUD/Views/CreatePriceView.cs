using SimpleProjectCRUD.Database;
using SimpleProjectCRUD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjectCRUD.Views
{
    public class CreatePriceView
    {
        private readonly IMenuService _menuService;
        public CreatePriceView(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Create Price");
            Console.WriteLine("-----------");

            Console.Write("Menu Id : ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Price   : ");
            int price = Convert.ToInt32(Console.ReadLine());

            var menuPrice = new MenuPrice();
            menuPrice.MenuId = Id;
            menuPrice.Price = price;

            _menuService.CreatePrice(menuPrice);
        }
    }
}
