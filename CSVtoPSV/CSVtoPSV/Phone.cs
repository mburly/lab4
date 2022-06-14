using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVtoPSV
{
    public class Phone
    {
        private int _countryCode;
        private int _areaCode;
        private int _exchangeCode;
        private int _lineNumber;
        private string _fullNumber;
        public int CountryCode
        {
            get { return _countryCode; }
        }
        public int AreaCode
        {
            get { return _areaCode; }
        }
        public int ExchangeCode
        {
            get { return _exchangeCode; }
        }
        public int LineNumber
        {
            get { return _lineNumber; }
        }
        public string FullNumber
        {
            get { return _fullNumber; }
        }

        public Phone(int countryCode, int areaCode, int exchangeCode, int lineNumber, string fullNumber)
        {
            _countryCode = countryCode;
            _areaCode = areaCode;
            _exchangeCode = exchangeCode;
            _lineNumber = lineNumber;
            _fullNumber = fullNumber;
        }
    }
}
