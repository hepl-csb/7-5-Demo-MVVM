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
            
            People = new ObservableCollection<Person>();
            People.Add(new Person("Toto"));
            People.Add(new Person("Titi"));
            People.Add(new Person("Tata"));
            People.Add(new Person("Tutu"));
            _upper = false;
        }
        
        public void ToggleCase()
        {
            foreach (Person person in People)
            {
              if (_upper)
                {
                    person.Name = person.Name.ToLower();
                }
                else
                {
                    person.Name = person.Name.ToUpper();
                }
                
            }
            _upper = !_upper;
        }
    }
}
