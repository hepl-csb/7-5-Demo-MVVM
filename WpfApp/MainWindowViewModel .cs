using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> People { get; set; }
        
        private bool _upper;

        private Person _currentPerson;

        public Person CurrentPerson
        {
            get => _currentPerson;
            set
            {
                _currentPerson = value;
                PropertyChangedEventHandler();
            }
        }

        public MainWindowViewModel() { 
            
            People = new ObservableCollection<Person>
            {
                new Person("Toto"),
                new Person("Titi"),
                new Person("Tata"),
                new Person("Tutu")
            };
            _upper = false;
        }
        
        public void ToggleCase()
        {
            foreach (Person person in People)
            {
                person.Name = _upper ? person.Name.ToLower() : person.Name.ToUpper();
            }
            _upper = !_upper;
        }
        private void PropertyChangedEventHandler([CallerMemberName] string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
