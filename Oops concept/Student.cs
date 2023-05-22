using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_concept.Abstraction;

class Student :Teacher
{
    public override void StudentDetails(string name,int rollnumber)
    {
     
       
        Console.WriteLine("student name is " + name);
        Console.WriteLine("student rollNumber is " + rollnumber);

    }
}
