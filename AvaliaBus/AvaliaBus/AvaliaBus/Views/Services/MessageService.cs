using System.Threading.Tasks;
using AvaliaBus.ViewModels.Services;

namespace AvaliaBus.Views.Services
{
    public class MessageService : IMessageService
    {
        public async Task ShowAsync(string message)
        {
            await App.Current.MainPage.DisplayAlert("AvaliaBus", message, "Fechar");
        }
    }
}