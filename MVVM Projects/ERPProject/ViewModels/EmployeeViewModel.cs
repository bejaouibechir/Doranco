//#define sql
#define json
using ERPProject.Helpers;
using ERPProject.Models.Abstraction;
using ERPProject.Models.ImplJson;

#if sql
    using ERPProject.Models.ImplSqlServer;
#endif

using System;
using System.Collections.ObjectModel;


#if json
    //using ERPProject.Models.ImplJson;
#endif

using System.Windows.Controls;

namespace ERPProject.ViewModels
{
    public class EmployeeViewModel :ViewModelBase
    {
        #region Les champs privés
#if json
       IRepository<Models.ImplJson.Employee> _repository;
        Models.ImplJson.Employee _Employee;
#endif
#if sql
        IRepository<Models.ImplSqlServer.Employee> _repository;
        Models.ImplSqlServer.Employee _Employee;
#endif


        DelegateCommand<string> _addEmployeecommand;
        DelegateCommand<string> _removeEmployeecommand;
        DelegateCommand<string> _updateEmployeecommand;
        DelegateCommand<string> _getEmployeecommand;
        DelegateCommand<string> _allEmployeecommand;
#endregion

#region constrcuteur    
        public EmployeeViewModel()
        {
            _repository = new EmployeeRepository();
            _Employee = new Employee();
        }

#endregion

#region Les propriétés

        public int EmployeeId
        {
            get { return _Employee.empid; }
            set { 
                _Employee.empid = value;
                OnPropertyChanged("EmployeeId");
            }
        }

        public string LastName
        {
            get { return _Employee.lastname; }
            set
            {
                _Employee.lastname = value;
                OnPropertyChanged("LastName");
            }
        }

        public string FirstName
        {
            get { return _Employee.firstname; }
            set
            {
                _Employee.firstname = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string Title
        {
            get { return _Employee.title; }
            set
            {
                _Employee.title = value;
                OnPropertyChanged("Title");
            }
        }

        public DateTime? HireDate
        {
            get { return _Employee.hiredate; }
            set
            {
                _Employee.hiredate = value;
                OnPropertyChanged("HireDate");
            }
        }

        public string Phone
        {
            get { return _Employee.phone; }
            set
            {
                _Employee.phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public Store Store
        {
            get { return _Employee.Store; }
            set
            {
                _Employee.Store = value;
                OnPropertyChanged("Store");
            }
        }


        public ObservableCollection<Order> Orders
        {
            get { return new ObservableCollection<Order>(_Employee.Orders); }
            set
            {
                _Employee.Orders = value;
                OnPropertyChanged("Orders");
            }
        }

#endregion


#region  les commandes 


#region ajout des employees 

        public DelegateCommand<string> AddEmployeecommand
        {
            get
            {
                return _addEmployeecommand;
            }
            set
            {
                _addEmployeecommand = new DelegateCommand<string>(canaddcommand, addcommand);
            }
        }

        private bool canaddcommand(object arg)
        {
            return true;
        }

        private void addcommand(object obj)
        {
            _repository.Add(_Employee);
        }
#endregion


#region La commande de mise à jour
        public DelegateCommand<string> Updateemployeecommand
        {
            get
            {
                return _updateEmployeecommand;
            }
            set
            {
                _updateEmployeecommand = new DelegateCommand<string>(canupdatecommand, updatecommand);
            }
        }

        private bool canupdatecommand(object arg)
        {
            return true;
        }

        private void updatecommand(object obj)
        {
            _repository.Update(_Employee.empid, _Employee);
        }



#endregion


#region La commande de suppression 
        public DelegateCommand<string> Removeemployeecommand
        {
            get
            {
                return _removeEmployeecommand;
            }
            set
            {
                _removeEmployeecommand = new DelegateCommand<string>(canremovecommand, removecommand);
            }
        }

        private bool canremovecommand(object arg)
        {
            return true;
        }

        private void removecommand(object obj)
        {
            _repository.Delete(_Employee);
        }



#endregion


#region La commande de recuperation de employee 
        public DelegateCommand<string> Getemployeecommand
        {
            get
            {
                return _getEmployeecommand;
            }
            set
            {
                _getEmployeecommand = new DelegateCommand<string>(cangetcommand, getcommand);
            }
        }

        private bool cangetcommand(object arg)
        {
            return true;
        }

        private void getcommand(object obj)
        {
            _repository.Get(_Employee.empid);
        }

#endregion


#region La commande de recuperation de tout les  employees 
        public DelegateCommand<string> Getallemployeecommand
        {
            get
            {
                return _allEmployeecommand;
            }
            set
            {
                _allEmployeecommand = new DelegateCommand<string>(cangetallcommand, getallcommand);
            }
        }

        private bool cangetallcommand(object arg)
        {
            return true;
        }

        private void getallcommand(object obj)
        {
            _repository.Get(_Employee.empid);
        }

#endregion



#endregion

    }
}
