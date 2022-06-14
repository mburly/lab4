using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVtoPSV
{
    public class Address
    {
        private int _number;
        private string _street;
        private string _city;
        private string _state;
        private string _zipCode;
        public int Number
        {
            get { return _number; }
        }
        public string Street
        {
            get { return _street; }
        }
        public string City
        {
            get { return _city; }
        }
        public string State
        {
            get { return _state; }
        }
        public string ZipCode
        {
            get { return _zipCode; }
        }

        public Address(int number, string street, string city, string state, string zipCode)
        {
            _number = number;
            _street = street;
            _city = city;
            _state = state;
            _zipCode = zipCode;
        }
    }
}
