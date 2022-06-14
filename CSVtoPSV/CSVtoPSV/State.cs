using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVtoPSV
{
    public class State
    {
        private string _abbreviation;
        private string _fullName;
        public string Abbreviation
        {
            get { return _abbreviation; }
        }
        public string FullName
        {
            get { return _fullName; }
        }
    }
}
