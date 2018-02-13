using ListaTarefas.Database;
using ListaTarefas.Model;
using ListaTarefas.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ListaTarefas.Command
{
    class ModificarTarefaCommand : ICommand
    {
        public TelaPrincipalViewModel telaPrincipalViewModel { get; set; }

        public ModificarTarefaCommand(TelaPrincipalViewModel telaPrincipalViewModel)
        {
            this.telaPrincipalViewModel = telaPrincipalViewModel;
        }

        //Métodos da interface ICommand
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var TarefaAtual = (Tarefa)parameter;
            if (TarefaAtual.Finalizada == true)
                TarefaAtual.Finalizada = false;
            else
                TarefaAtual.Finalizada = true;
            telaPrincipalViewModel.TarefaAtual = TarefaAtual;
            new AtualizarTarefaCommand().AtualizarTarefa(telaPrincipalViewModel);
        }
    }
}
