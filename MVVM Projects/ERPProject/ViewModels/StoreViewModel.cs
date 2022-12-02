//#define sql
#define json
using ERPProject.Helpers;
using ERPProject.Models.Abstraction;

#if sql
using ERPProject.Models.ImplSqlServer;
using ERPProject.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;
#endif

#if json
    using ERPProject.Models.ImplJson;
using System.Collections.ObjectModel;
#endif

using System.Windows.Controls;

namespace ERPProject.ViewModels
{
    public class StoreViewModel :ViewModelBase
    {
        #region Les champs privés

        IRepository<Store> _repository;
        Store _store;
        DelegateCommand<string> _addstorecommand;
        DelegateCommand<string> _removestorecommand;
        DelegateCommand<string> _updatestorecommand;
        DelegateCommand<string> _getstorecommand;
        DelegateCommand<string> _allstorecommand;
        #endregion

        #region constrcuteur    
        public StoreViewModel()
        {
            _repository = new StoreRepository();
            Addstorecommand = new DelegateCommand<string>(canaddcommand, addcommand);
            Updatestorecommand = new DelegateCommand<string>(canupdatecommand, updatecommand);
            Removestorecommand = new DelegateCommand<string>(canremovecommand, removecommand);
            Getstorecommand = new DelegateCommand<string>(cangetcommand, getcommand);
            Getallstorecommand = new DelegateCommand<string>(cangetallcommand, getallcommand);
            _store = new Store();

        }

        #endregion

        #region Les propriétés

        public int StoreId
        {
            get { return _store.storeid; }
            set { 
                _store.storeid = value;
                OnPropertyChanged("StoreId");
            }
        }

        public string StoreName
        {
            get { return _store.storename; }
            set
            {
                _store.storename = value;
                OnPropertyChanged("StoreName");
            }
        }

        public string City
        {
            get { return _store.city; }
            set
            {
                _store.city = value;
                OnPropertyChanged("City");
            }
        }

        public string Country
        {
            get { return _store.country; }
            set
            {
                _store.country = value;
                OnPropertyChanged("Country");
            }
        }

        public ObservableCollection<Employee> Employees
        {
            get { return new ObservableCollection<Employee>(_store.Employees); }
            set
            {
                _store.Employees = value;
                OnPropertyChanged("Employees");
            }
        }

        #endregion

        #region  les commandes 

        #region La commande d'ajout
        public DelegateCommand<string> Addstorecommand
        {
            get
            {
                return _addstorecommand;
            }
            set
            {
                _addstorecommand = new DelegateCommand<string>(canaddcommand, addcommand);
            }
        }

        private bool canaddcommand(object arg)
        {
            return true;
        }

        private void addcommand(object obj)
        {
            _repository.Add(_store);
        }
        #endregion


        #region La commande de mise à jour
        public DelegateCommand<string> Updatestorecommand
        {
            get
            {
                return _updatestorecommand;
            }
            set
            {
                _addstorecommand = new DelegateCommand<string>(canupdatecommand, updatecommand);
            }
        }

        private bool canupdatecommand(object arg)
        {
            return true;
        }

        private void updatecommand(object obj)
        {
            _repository.Update(_store.storeid,_store);
        }



        #endregion


        #region La commande de suppression 
        public DelegateCommand<string> Removestorecommand
        {
            get
            {
                return _removestorecommand;
            }
            set
            {
                _removestorecommand = new DelegateCommand<string>(canremovecommand, removecommand);
            }
        }

        private bool canremovecommand(object arg)
        {
            return true;
        }

        private void removecommand(object obj)
        {
            _repository.Delete(_store);
        }



        #endregion


        #region La commande de recuperation de store 
        public DelegateCommand<string> Getstorecommand
        {
            get
            {
                return _getstorecommand;
            }
            set
            {
                _getstorecommand = new DelegateCommand<string>(cangetcommand, getcommand);
            }
        }

        private bool cangetcommand(object arg)
        {
            return true;
        }

        private void getcommand(object obj)
        {
            _repository.Get(_store.storeid);
        }

        #endregion


        #region La commande de recuperation de tout les  stores 
        public DelegateCommand<string> Getallstorecommand
        {
            get
            {
                return _allstorecommand;
            }
            set
            {
                _allstorecommand = new DelegateCommand<string>(cangetallcommand, getallcommand);
            }
        }

        private bool cangetallcommand(object arg)
        {
            return true;
        }

        private void getallcommand(object obj)
        {
            _repository.Get(_store.storeid);
        }

        #endregion



        #endregion

    }
}
