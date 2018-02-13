using ListaTarefas.Database;
using ListaTarefas.Model;
using ListaTarefas.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTarefas.Command
{
    class AtualizarTarefaCommand
    {
        public void AtualizarTarefa(TelaPrincipalViewModel telaPrincipalViewModel)
        {
            for (int i = 0; i < telaPrincipalViewModel.Tarefas.Count; i++)
            {
                if (telaPrincipalViewModel.Tarefas[i].Id == telaPrincipalViewModel.TarefaAtual.Id)
                {
                    telaPrincipalViewModel.Tarefas[i] = telaPrincipalViewModel.TarefaAtual;
                }
            }
            new TarefasDataAccess().AtualizarTarefa(telaPrincipalViewModel.TarefaAtual);
            telaPrincipalViewModel.TarefaAtual = new Tarefa();
        }
    }
}
