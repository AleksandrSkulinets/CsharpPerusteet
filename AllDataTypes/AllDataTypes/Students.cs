using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDataTypes
{
    class Students
    {
        public string Name { get; set; }
        public int Mark { get; set; }
        public int Subjects { get; set; }


        public char GetInitial(string firstname)
        {
            firstname = Name;          
            char initial = firstname.Substring(0, 1)[0];
            return initial;
        }
        public double Points(int ns, int mark )
        {
            ns = Subjects;
            mark = Mark;
            double points = ns* mark * 0.5;
            return points;

        }

    }
    
}
