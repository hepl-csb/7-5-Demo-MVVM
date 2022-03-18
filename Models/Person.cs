using System.ComponentModel;

namespace Models
{

    public class Person:INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { 
                _name = value;
                PropertyChangedEventHandler(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public Person(string name = "Default")
        {
            Name = name;
        }
        private void PropertyChangedEventHandler(Person person, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            PropertyChanged?.Invoke(person, propertyChangedEventArgs);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

    }
}