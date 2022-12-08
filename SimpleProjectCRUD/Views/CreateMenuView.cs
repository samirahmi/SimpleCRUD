using SimpleProjectCRUD.Database;
using SimpleProjectCRUD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjectCRUD.Views
{
    public class CreateMenuView
    {
        private readonly IMenuService _menuService;
        public CreateMenuView(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Create Menu");
            Console.WriteLine("-----------");

            Console.Write("Menu Code : ");
            var code = Console.ReadLine();
            Console.Write("Menu Name : ");
            string name = Console.ReadLine();

            var menu = new Menu();
            menu.MenuCode = code;
            menu.MenuName = name;

            _menuService.CreateMenu(menu);
        }
    }
}
