using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp
{
    internal class MainWindowViewModel
    {
        public ObservableCollection<Person> People { get; set; }
        private bool _upper;

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
    }
}
