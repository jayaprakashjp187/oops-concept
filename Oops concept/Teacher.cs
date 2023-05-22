using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oops_concept
{
    abstract class Teacher
    {
        public abstract  void  StudentDetails(string name,int rollnumber);
        public int GetMarks()
        {
            int studentMarks = 98;
            return studentMarks;
        }
    }
}
