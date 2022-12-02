using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPProject.Models.Abstraction
{
   /// <summary>
   /// Représente l'abstraction
   /// </summary>
   /// <typeparam name="T">T peut etre soit Store soit employees soit orders</typeparam>
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(int id, T newentity);
        void Delete(T entity);

        T Get(int id);

        ObservableCollection<T> All();

    }
}
