using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using TutorialMVVM.DataAccess;

namespace TutorialMVVM.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        readonly EmployeeRepository _employeeRepository;

        ObservableCollection<ViewModelBase> _viewModels;

        public MainWindowViewModel()
        {
            _employeeRepository = new EmployeeRepository();
            //create an instance of our viewmodel add it to our collection
            EmployeeListViewModel viewModel = new EmployeeListViewModel(_employeeRepository);
            this.ViewModels.Add(viewModel);
        }

        public ObservableCollection<ViewModelBase> ViewModels
        {
            get
            {
                if (_viewModels == null)
                {
                    _viewModels = new ObservableCollection<ViewModelBase>();
                }
                return _viewModels;
            }
        }

    }
}
