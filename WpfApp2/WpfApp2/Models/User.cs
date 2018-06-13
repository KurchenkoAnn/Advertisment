using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace WpfApp2
{
    public class User : IDataErrorInfo
    {
         
     
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Error => throw new NotImplementedException();
       
        public string this[string columnName]
        {
            get
            {
                string m = "";
                if (columnName == "Name")
                {
                    if (Char.IsUpper(Name[0]) == false)
                    {
                        m = "First letter must be upper";
                    }

                }
                if (columnName == "Age")
                {
                    if (Age <= 0)
                    {
                        m = "Age must be positive";
                    }

                }
                if (columnName == "Phone" )
                {
                    if (Phone.Length == 10 )
                    {
                        m = $"({Phone.Substring(0, 3)}) {Phone.Substring(3, 3)}-{Phone.Substring(6, 4)}";
                    }

                }
                if (columnName == "City")
                {
                    if (Char.IsUpper(Name[0]) == false)
                    {
                        m = "First letter must be upper";
                    }

                }
                if (columnName == "Login" )
                {
                    if (Login.Contains("bad"))
                    {
                        m = "bad language";
                    }
                    if (columnName == "Login")
                    {
                        if (!Mail.Contains("@"))
                        {
                            m = "Mail must contain @";
                        }
                    }
                }
                if (columnName == "Password")
                {
                   
                    if (Password.Length <= 8)
                    {
                        m = "The password is too small";
                    }
                }
                
                return m;
               
            }
        }


    }
}
