using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApp.Model
{
    public class Promotion
    {
        public DateTime DatePromotion { get; set; }

        public Grades Grade { get; set; }
    }

    public enum Grades
    {
        CategorieA, CategorieB, CategorieC
    }
}
