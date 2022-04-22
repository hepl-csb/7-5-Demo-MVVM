using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Models
{

    public class Person:INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get => _name;
            set { 
                _name = value;
                PropertyChangedEventHandler();
            }
        }

        public Person(string name = "Default")
        {
            Name = name;
        }

        public Person():this("")
        {
        }

        public override string ToString()
        {
            return Name;

        }

        private void PropertyChangedEventHandler([CallerMemberName] string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

    }
}