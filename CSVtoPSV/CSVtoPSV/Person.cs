using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVtoPSV
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private Address _address;
        private Phone _phone1;
        private Phone _phone2;
        public string FirstName
        {
            get { return _firstName; }
        }
        public string LastName
        {
            get { return _lastName; }
        }
        public Address Address
        {
            get { return _address; }
        }
        public Phone Phone1
        {
            get { return _phone1; }
        }
        public Phone Phone2
        {
            get { return _phone2; }
        }

        public Person(string firstName, string lastName, Address address, Phone phone1, Phone phone2)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _phone1 = phone1;
            _phone2 = phone2;
        }

        public override string ToString()
        {
            return $"{this.FirstName}|{this.LastName}|\"{this.Address.Number} {this.Address.Street}\"|{this.Address.City}|{this.Address.State}|{this.Address.ZipCode}|" +
                $"{this.Phone1.FullNumber}|{this.Phone2.FullNumber}";
        }
    }
}
