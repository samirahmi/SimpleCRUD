using SimpleProjectCRUD.Database;
using SimpleProjectCRUD.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjectCRUD.Services
{
    public interface IMenuService
    {
        void CreateMenu(Menu menu);
        void Update(Menu menu);
        List<MenuDto> GetAllMenus();
        void Delete(int menuId);
        void CreatePrice(MenuPrice price);
        Menu GetMenuById(int Id);
    }
}
