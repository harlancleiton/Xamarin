using System.ComponentModel;

namespace AvaliaBus.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void Notify(string propertyName)
        {
            /*
             * PropertyChanged !=, ou seja, alguem assinou esse evento
             * Entao informamos que o sender é a própria classe e passamos como parametro o nome da propriedade que foi modificada
             */
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}