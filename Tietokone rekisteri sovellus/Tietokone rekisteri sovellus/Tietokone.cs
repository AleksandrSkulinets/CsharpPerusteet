using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tietokone_rekisteri_sovellus
{
    class Tietokone
    {
        public class Computer
        {
            public int id { get; set; }
            public string name { get; set; }

            public string model { get; set; }

            public Ownership Owmership { get; set; }
        }
        public enum Ownership
        {
            Own,
            Leasing
        }
        public class Spaces
        {
            public int id { get; set; }
            public string name { get; set; }
            public string orderid { get; set; }
            public virtual ICollection<Computer> Computers { get; set; }

        }
    }
}
