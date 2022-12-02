#define sql
//#define json
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
#endif

using System.Windows.Controls;

namespace ERPProject.ViewModels
{
    public class OrderViewModel :ViewModelBase
    {
        #region Les champs privés

        IRepository<Order> _repository;
        Order _Order;
        DelegateCommand<string> _addOrdercommand;
        DelegateCommand<string> _removeOrdercommand;
        DelegateCommand<string> _updateOrdercommand;
        DelegateCommand<string> _getOrdercommand;
        DelegateCommand<string> _allOrdercommand;
        #endregion

        #region constrcuteur    
        public OrderViewModel()
        {
            _repository = new OrderRepository();
            _Order = new Order();
        }

        #endregion

        #region Les propriétés

        public int OrderId
        {
            get { return _Order.orderid; }
            set { 
                _Order.orderid = value;
                OnPropertyChanged("OrderId");
            }
        }

        public DateTime OrderDate
        {
            get { return _Order.orderdate; }
            set
            {
                _Order.orderdate = value;
                OnPropertyChanged("OrderDate");
            }
        }

        public decimal Freight
        {
            get { return _Order.freight; }
            set
            {
                _Order.freight = value;
                OnPropertyChanged("Freight");
            }
        }

        public string ShipCity
        {
            get { return _Order.shipcity; }
            set
            {
                _Order.shipcity = value;
                OnPropertyChanged("ShipCity");
            }
        }

        public Employee Employee
        {
            get { return _Order.Employee; }
            set
            {
                _Order.Employee = value;
                OnPropertyChanged("Employee");
            }
        }
        #endregion

        #region  les commandes 

        public DelegateCommand<string> AddOrdercommand
        {
            get
            {
                return _addOrdercommand;
            }
            set
            {
                _addOrdercommand = new DelegateCommand<string>(canaddcommand, addcommand);
            }
        }

        private bool canaddcommand(object arg)
        {
            return true;
        }

        private void addcommand(object obj)
        {
            _repository.Add(_Order);
        }




        #endregion

    }
}
