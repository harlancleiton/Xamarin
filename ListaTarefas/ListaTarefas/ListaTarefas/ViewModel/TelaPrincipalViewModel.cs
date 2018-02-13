using ListaTarefas.Command;
using ListaTarefas.Database;
using ListaTarefas.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListaTarefas.ViewModel
{
    /*
     * O método implementado pela interface INotifyPropertyChanged
     * serve para avisar a tela(view) que um campo sofreu alteração
     */

    /*
     * Utilizando o ObservableCollection não é necessário implementar o OnPropertyChanged
     * ObservableCollection é uma classe que faz tudo sozinha
     * Notifica quando uma informação da minha lista ou propriedade for alterada
     */
    public class TelaPrincipalViewModel: INotifyPropertyChanged
    {
        public Tarefa TarefaAtual { get; set; }
        public ObservableCollection<Tarefa> Tarefas { get; set; }
        public Xamarin.Forms.Command SalvarTarefaCommand { get; set; }
        public Xamarin.Forms.Command EditarTarefaCommand { get; set; }
        public ICommand ModificarTarefaCommand { get; set; } //Implementando uma classe command para ver como funciona
        public Xamarin.Forms.Command ExcluirTarefaCommand { get; set; }

        public TelaPrincipalViewModel()
        {
            TarefaAtual = new Tarefa();
            Tarefas = new ObservableCollection<Tarefa>( new TarefasDataAccess().GetTarefas());
            SalvarTarefaCommand = new Xamarin.Forms.Command(SalvarTarefa); //Falhei na tentativa de implementar um command
            EditarTarefaCommand = new Xamarin.Forms.Command<Tarefa>(EditarTarefa);
            //ModificarTarefaCommand = new Xamarin.Forms.Command<Tarefa>(ModificarTarefa);
            /*
             * Aqui chamamos a classe que ficará responsavel por executar o command
             * Levando a própria classe como parametro atraves do this
             */
            ModificarTarefaCommand = new Command.ModificarTarefaCommand(this);
            ExcluirTarefaCommand = new Xamarin.Forms.Command<Tarefa>(ExcluirTarefa);
        }

        private void SalvarTarefa()
        {
            //A função salvar precisa saber se é pra salvar uma nova tarefa (não possue Id) ou editar uma já existente (possue Id)
            if (TarefaAtual.Id == 0 && !TarefaAtual.Nome.Equals(""))
            {
                TarefaAtual.Finalizada = false;
                new TarefasDataAccess().SalvarTarefa(TarefaAtual);
                Tarefas.Add(TarefaAtual);
            }
            else
            {
                AtualizarTarefa();
            }
            TarefaAtual = new Tarefa();
            OnPropertyChanged("TarefaAtual");
        }

        private void AtualizarTarefa()
        {
            new TarefasDataAccess().AtualizarTarefa(TarefaAtual);
            for (int i = 0; i < Tarefas.Count; i++)
            {
                if (Tarefas[i].Id == TarefaAtual.Id)
                {
                    Tarefas[i] = TarefaAtual;
                }
            }
        }

        private void EditarTarefa(Tarefa TarefaAux)
        {
            TarefaAtual = TarefaAux;
            OnPropertyChanged("TarefaAtual");
        }

        /*
        private void ModificarTarefa(Tarefa TarefaAux)
        {
            TarefaAtual = TarefaAux;
            if (TarefaAtual.Finalizada == true)
                TarefaAtual.Finalizada = false;
            else
                TarefaAtual.Finalizada = true;
            AtualizarTarefa();
            TarefaAtual = new Tarefa();
            OnPropertyChanged("TarefaAtual");
            //TarefaAtual.Finalizada = Finalizada;
            //OnPropertyChanged("TarefaAtual");
        }
        */

        private void ExcluirTarefa(Tarefa TarefaAux)
        {
            new TarefasDataAccess().ExcluirTarefa(TarefaAux);
            Tarefas.Remove(TarefaAux);
        }

        //Implementados da interface
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}