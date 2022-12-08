using Microsoft.Extensions.DependencyInjection;
using SimpleProjectCRUD.Configuration;
using SimpleProjectCRUD.Views;

class Program
{
    static void Main()
    {
        DInjections dInjections = new DInjections();
        var createMenuView = dInjections.Provider.GetService<CreateMenuView>();
        var createPriceView = dInjections.Provider.GetService<CreatePriceView>();
        var reportView = dInjections.Provider.GetService<ReportView>();
        var updateView = dInjections.Provider.GetService<UpdateView>();
        var deleteView = dInjections.Provider.GetService<DeleteView>();

        bool showMenu = true;
        while (showMenu)
        {
            Console.Clear();
            Console.WriteLine("Welcome To 'CRUD MENU'");
            Console.WriteLine("----------------------");
            Console.WriteLine("Choose an Option: ");
            Console.WriteLine("1) Create Menu");
            Console.WriteLine("2) Create Price");
            Console.WriteLine("3) Report Menu");
            Console.WriteLine("4) Update Menu");
            Console.WriteLine("5) Delete Menu");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    createMenuView.DisplayView();
                    showMenu = true;
                    break;
                case "2":
                    createPriceView.DisplayView();
                    showMenu = true;
                    break;
                case "3":
                    reportView.DisplayView();
                    showMenu = true;
                    break;
                case "4":
                    updateView.DisplayView();
                    showMenu = true;
                    break;
                case "5":
                    deleteView.DisplayView();
                    showMenu = true;
                    break;
                case "6":
                    showMenu = false;
                    break;
                default:
                    showMenu = true;
                    break;
            }
        }
    }
}
