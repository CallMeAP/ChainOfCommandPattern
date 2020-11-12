using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ChainOfCommandPattern
{
    public class User
    {
        public User(string name, string insurancNumber, RegionInfo regionInfo, DateTimeOffset dateOfBirth)
        {
            this.Name = name;
            this.InsurancNumber = insurancNumber;
            this.RegionInfo = regionInfo;
            this.DateOfBirth = dateOfBirth;
        }

        public string Name { get; set; }

        public string InsurancNumber { get; set; }

        public RegionInfo RegionInfo { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }
    }
}
