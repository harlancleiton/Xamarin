using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliaBus.Views;

namespace AvaliaBus.Models.Services
{
    public class MenuService
    {
        public List<MenuModel> GetMenu()
        {
            return LoadMenu();
        }

        private List<MenuModel> LoadMenu()
        {
            List<MenuModel> Menu = new List<MenuModel>();

            Menu.Add(new MenuModel
            {
                Icon = "bus_bar_dark.png",
                ViewName = "EvaluationView",
                Title = "Avalie sua viagem"
            });

            Menu.Add(new MenuModel
            {
                Icon = "historic_bar_dark.png",
                ViewName = "HistoricView",
                Title = "Histórico de avaliações"
            });

            Menu.Add(new MenuModel
            {
                Icon = "user_bar_dark.png",
                ViewName = "UserView",
                Title = "Meu usuário"
            });

            Menu.Add(new MenuModel
            {
                Icon = "settings_bar_dark.png",
                ViewName = "SettingsView",
                Title = "Configurações"
            });

            Menu.Add(new MenuModel
            {
                Icon = "help_bar_dark.png",
                ViewName = "AboutView",
                Title = "Sobre"
            });

            Menu.Add(new MenuModel
            {
                Icon = "exit_bar_dark.png",
                ViewName = "ExitView",
                Title = "Sair"
            });

            return Menu;
        }
    }
}
