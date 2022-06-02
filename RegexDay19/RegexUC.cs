using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDay19
{
    internal class RegexUC
    {
        public static string RegexFirstName = "^[A-Z]{1}[a-z]{3,}$";
        public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, RegexFirstName);
        }

        public static string RegexLastName = "^[A-Z]{1}[a-z]{3,}$";
        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, RegexLastName);

        }

        public static string RegexEmail = "^[0-9a-zA-Z]+([+#%&_.][a-zA-Z0-9]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, RegexEmail);
        }

        // abc.xyz@bl.co.in

        
        
            public static string RegexMobileNumber = "^[1-9]{2} [6-9]{1}[0-9]{9}$";
            public bool validateMobileNumber(string MobileNumber)
            {
                return Regex.IsMatch(MobileNumber, RegexMobileNumber);
            }
        

        
        
            public static string RegexPassword = "^[a-zA-Z]{8,}$";
            public bool validatePassword(string Password)
            {
                return Regex.IsMatch(Password, RegexPassword);
            }

            
            
                public static string RegexPassword6 = "^[A-Z]{1,}[a-z]{7,}$";
                public bool validatePassword6(string Password6)
                {
                    return Regex.IsMatch(Password6, RegexPassword6);
                }
            

            public static string RegexPassword7 = "^[A-Z]{1,}[a-z]{5,}[0-9]{1,}$";
            public bool validatePassword7(string Password7)
            {
                return Regex.IsMatch(Password7, RegexPassword7);
            }

        public static string RegexPassword8 = "^[A-Z]{1,}[a-z]{5,}[0-9]{1,}[@#&*]{1}$";
        public bool validatePassword8(string Password8)
        {
            return Regex.IsMatch(Password8, RegexPassword8);
        }

        public static string RegexEmail9 = "^[0-9a-zA-Z]+([+#%&_.-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{3}([.][a-zA-Z]{2,3})?$";
        public bool validateEmail9(string Email9)
        {
            return Regex.IsMatch(Email9, RegexEmail9);
        }
    }
}
               //• A.Valid Emails
               //• 1. abc@yahoo.com,
                  //• 2. abc-100@yahoo.com,
                  //• 3. abc.100@yahoo.com
                    //  • 2. abc111@abc.com,
                      // • 4. abc-100@abc.net,
                        //• 5. abc.100@abc.com.au
                        // • 6. abc@1.com,
                      //• 7. abc@gmail.com.com
                       //• 8. abc+100@gmail.com



    


