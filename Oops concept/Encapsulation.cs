using Oops_concept.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_concept
{
    internal class Encapsulation
    {
        private string studentName;
        private int studentId;
        public string getStudentName() 
        {
            return studentName;
        }
        public int getStudentId() 
        {
            return studentId;
        }
        public void setStudentName(string Name)
        {
            studentName = Name;
        }
        public void setStudentId(int id)
        {
            studentId = id;
        }
    }
}
