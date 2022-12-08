using SimpleProjectCRUD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjectCRUD.Views
{
    public class ReportView
    {
        private readonly IMenuService _menuService;
        public ReportView(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public void DisplayView()
        {
            Console.Clear();

            Console.WriteLine("List Of Menu");
            var listMenu = _menuService.GetAllMenus();

            foreach (var menu in listMenu)
            {
                Console.WriteLine($"{menu.MenuCode} - {menu.MenuName} - {menu.Price}");
            }

            Console.ReadKey();
        }
    }
}
