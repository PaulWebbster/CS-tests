using System;
using System.Collections.ObjectModel;
using TutorialMVVM.DataAccess;

namespace TutorialMVVM.ViewModel
{
    class EmployeeListViewModel : ViewModelBase
    {
        readonly EmployeeRepository _employeeRepository;

        public ObservableCollection<Model.Employee> AllEmployess
        {
            get;
            private set;
        }

        public EmployeeListViewModel(EmployeeRepository employeeRepository)
        {
            if (employeeRepository == null)
            {
                throw new ArgumentNullException("employeeRepository");
            }
            _employeeRepository = employeeRepository;

            this.AllEmployess = new ObservableCollection<Model.Employee>(_employeeRepository.GetEmployees());
        }

        protected override void OnDispose()
        {
            this.AllEmployess.Clear();
        }
    }
}
