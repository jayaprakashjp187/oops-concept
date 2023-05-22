using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_concept
{
     class Calculator
    {
        public void Add(int i,int j)
        
        {
            int c = i + j;
            Console.WriteLine("sum of" +i +"+" +j +"=" +c);
        }
         public void Add(int i,float j)
        {
            Console.WriteLine(i);
            Console.WriteLine(j);
            float c = i + j;
             Console.WriteLine("sum of" + i +"+" + j + "=" + c);

        }

      
    }
}
