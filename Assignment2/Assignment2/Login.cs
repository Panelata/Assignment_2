using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Login
    {
        private String firstName;
        private String lastName;
        private String userName;
        private String password;
        private String DOB;
        private String userType;

        public Login(String userName, String password, String userType, String firstName, String lastName, String DOB)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.password = password;
            this.DOB = DOB;
            this.userType = userType;
        }

        public String getUsername()
        {
            return this.userName;
        }

        public String getPassword()
        {
            return this.password;
        }

        public override string ToString()
        {
            return userName +"," + password + "," + userType + "," + firstName + "," + lastName + "," + DOB;
            //return "First: " + firstName + " Last: " + lastName + " Username: "+ userName + " password: "+ password+ "DOB: " + DOB + " UserType: " + userType;
        }
    }
}
