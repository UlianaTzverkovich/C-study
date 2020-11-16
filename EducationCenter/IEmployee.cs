using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter
{
    interface IEmployee
    {
        void Vacation();
        bool IfVacation
        {
            get;
            set;
        }
        void Sick();
        bool IfSick
        {
            get;
            set;
        }
    }
}
