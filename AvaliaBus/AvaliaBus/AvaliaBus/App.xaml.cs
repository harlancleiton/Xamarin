using System.Threading.Tasks;
using AvaliaBus.ViewModels.Services;
using AvaliaBus.Views;
using AvaliaBus.Views.Services;
using Xamarin.Forms;

namespace AvaliaBus
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDetail { get; set; }

        public static async Task NavigateMasterDetail(Page page)
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.Detail.Navigation.PushAsync(page);
        }

        public App()
        {
            InitializeComponent();

            /*
             * Dependencia: Setar interface no Register e a implementação
             * Isso faz com quem toda vez que alguem procure por IMessegeService, seja criado uma instancia de MessegeService
             */
            DependencyService.Register<IMessageService, MessageService>();
            DependencyService.Register<INavigationService, NavigationService>();

            MainPage = new LoginView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}