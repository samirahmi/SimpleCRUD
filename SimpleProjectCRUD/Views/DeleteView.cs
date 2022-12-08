using SimpleProjectCRUD.Database;
using SimpleProjectCRUD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjectCRUD.Views
{
    public class DeleteView
    {
        private readonly IMenuService _menuService;
        public DeleteView(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Delete Menu");
            Console.WriteLine("-----------");

            Console.Write("Type Menu Id : ");
            int menuId = Convert.ToInt32(Console.ReadLine());
            var result = _menuService.GetMenuById(menuId);

            if (result != null)
            {
                Console.WriteLine($"Menu Code : {result.MenuCode} ");
                Console.WriteLine($"Menu Name : {result.MenuName}");

                Console.Write("Are you sure want to DELETE this record? (Y/N)");
                var choise = Console.ReadLine();

                if (choise.ToUpper().Equals("Y"))
                {
                    var menu = new Menu();
                    menu.MenuId = result.MenuId;
                    menu.MenuCode = result.MenuCode;
                    menu.MenuName = result.MenuName;

                    _menuService.Delete(menuId);
                }
            }
            else
            {
                Console.WriteLine("Data Not Found!");
                Console.ReadKey();
            }
        }
    }
}
