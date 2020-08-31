using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStaticGetSet
{
    class Ninja
    {

        private string _name = "";
        public string Name {
            get
            {
                return _name.ToUpper();
            }
            set
            {
                _name = value;
            } 
        }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Country { get; set; }


        private int _startpoint = 5;
        public int StartPoint {
            get
            {
                return _startpoint;
            }
            set
            {
                _startpoint = value;
            }
        }
    }
}
