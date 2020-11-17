using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Common;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class PersonViewModel : ViewModelBase
    {
        private Person _person = new Person();

        public Person Person
        {
            get { return _person; }
            set
            {
                _person = value;
                OnPropertyChanged(nameof(Person));
            }
        }

        private ICommand _updatePersonCommand;
        public ICommand UpdatePeronsCommand
        {
            get { return _updatePersonCommand; }
            set
            {
                _updatePersonCommand = value;
                OnPropertyChanged(nameof(UpdatePeronsCommand));
            }
        }
        public PersonViewModel(Person person)
        {
            _person = person;
            OnPropertyChanged(nameof(Person));
            UpdatePeronsCommand = new RelayCommand<object>(UpdatePerson);
        }

        private void UpdatePerson(object person)
        {
            if (person.GetType().Equals( typeof(Person)))
            {
                Person resPerson = (Person)person;
                String message = String.Format("Person Updated {0} , {1}", resPerson.FirstName, resPerson.LastName);
                MessageBox.Show(message);
            }
        }

        //Fonction1
        //Fonction2

    }
}
