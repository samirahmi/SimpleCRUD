using SimpleProjectCRUD.Database;
using SimpleProjectCRUD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjectCRUD.Views
{
    public class UpdateView
    {
        private readonly IMenuService _menuService;
        public UpdateView(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Update Menu");
            Console.WriteLine("-----------");

            Console.Write("Type Menu Id : ");
            int menuId = Convert.ToInt32(Console.ReadLine());
            var result = _menuService.GetMenuById(menuId);

            if (result != null)
            {
                Console.WriteLine($"Menu Code : {result.MenuCode} ");
                Console.WriteLine($"Menu Name : {result.MenuName}");

                Console.Write("Are you sure want to UPDATE this record? (Y/N)");
                var choise = Console.ReadLine();

                if (choise.ToUpper().Equals("Y"))
                {
                    Console.Write("Menu Code : ");
                    var code = Console.ReadLine();
                    Console.Write("Menu Name : ");
                    string name = Console.ReadLine();

                    var menu = new Menu();
                    menu.MenuCode = code;
                    menu.MenuName = name;

                    _menuService.Update(menu);
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
