using Dapper;
using Npgsql;
using SimpleProjectCRUD.Database;
using SimpleProjectCRUD.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjectCRUD.Services
{
    public class MenuService : IMenuService
    {
        private readonly string consTsring = @"Host=localhost;Username=postgres;Password=sami;Database=MenuDB";
        public void CreateMenu(Menu menu)
        {
            using (var connection = new NpgsqlConnection(consTsring))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute("INSERT INTO Menu (MenuId, MenuCode, MenuName)" +
                        " VALUES (@MenuId, @MenuCode, @MenuName)",
                        new
                        {
                            menu.MenuId,
                            menu.MenuCode,
                            menu.MenuName
                        });
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
                connection.Close();
            }
        }

        public void CreatePrice(MenuPrice price)
        {
            using (var connection = new NpgsqlConnection(consTsring))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute("INSERT INTO MenuPrice (MenuPriceId, MenuId, Price)" +
                        " VALUES (@MenuPriceId, @MenuId, @Price)",
                        new
                        {
                            price.MenuPriceId,
                            price.MenuId,
                            price.Price
                        });
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
                connection.Close();
            }
        }

        public void Delete(int menuId)
        {
            using (var connection = new NpgsqlConnection(consTsring))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute("DELETE FROM Menu WHERE MenuId = @MenuId", new { Id = menuId });
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
                connection.Close();
            }
        }

        public List<MenuDto> GetAllMenus()
        {
            List<MenuDto> listMenu = new List<MenuDto>();
            using (var connection = new NpgsqlConnection(consTsring))
            {
                connection.Open();
                listMenu = connection.Query<MenuDto>(@"SELECT m.MenuCode, m.MenuName, p.Price FROM Menu as m " +
                    "JOIN MenuPrice as p ON m.MenuId = p.MenuId").ToList();
                connection.Close();
            }
            return listMenu;
        }

        public Menu GetMenuById(int Id)
        {
            var menu = new Menu();
            using(var connection = new NpgsqlConnection(consTsring))
            {
                connection.Open();
                var listMenu = connection.Query<Menu>(@"SELECT * FROM Menu WHERE MenuId = @MenuId", new { Id }).ToList();

                menu = listMenu.FirstOrDefault();
                connection.Close();
            }

            return menu;
        }

        public void Update(Menu menu)
        {
            using (var connection = new NpgsqlConnection(consTsring))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute("UPDATE Menu SET MenuId = @MenuId," +
                        " MenuCode = @MenuCode," +
                        " MenuName = @MenuName" +
                        " WHERE MenuId = @MenuId",
                        new
                        {
                            menu.MenuId,
                            menu.MenuCode,
                            menu.MenuName
                        });
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
                connection.Close();
            }
        }
    }
}
