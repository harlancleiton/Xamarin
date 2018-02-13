using System.Threading.Tasks;

namespace AvaliaBus.ViewModels.Services
{
    /// <summary>
    /// A interface vai modelar, vai me dizer que eu tenho que exibir a mensagem
    /// Como vai ser mostrada a mensagem depende da view
    /// </summary>
    public interface IMessageService
    {
        Task ShowAsync(string message);
    }
}
