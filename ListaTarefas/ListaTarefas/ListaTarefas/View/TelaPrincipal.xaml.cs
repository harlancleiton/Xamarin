using ListaTarefas.Database;
using ListaTarefas.Model;
using ListaTarefas.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaTarefas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaPrincipal : ContentPage
    {
        public Tarefa TarefaAux { get; set; }
        public TelaPrincipal()
        {
            InitializeComponent();

            BindingContext = new TelaPrincipalViewModel();
        }
    }
}