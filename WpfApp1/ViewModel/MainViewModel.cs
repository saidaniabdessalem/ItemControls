using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Common;

namespace WpfApp1.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private List<PersonViewModel> _personViewModels = new List<PersonViewModel>();
        public List<PersonViewModel> PersonViewModels
        {
            get { return _personViewModels; }
            set
            {
                _personViewModels = value;
                OnPropertyChanged(nameof(PersonViewModel));
            }
        }


        public MainViewModel()
        {
            _personViewModels.Add(  new PersonViewModel(new Model.Person() { Id = 0, FirstName = "Abdessalem", LastName = "Saidani" })  );
            _personViewModels.Add(new PersonViewModel(new Model.Person() { Id = 1, FirstName = "Benoit", LastName = "Jermain" }));
            _personViewModels.Add(new PersonViewModel(new Model.Person() { Id = 1, FirstName = "Jean-Francoi", LastName = "Dutoit" }));

            OnPropertyChanged(nameof(PersonViewModel));


            
        }

      
    }
}
