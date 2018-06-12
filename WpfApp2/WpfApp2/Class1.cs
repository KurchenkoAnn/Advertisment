using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace WpfApp2
{
    class User : IDataErrorInfo
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public int Age { get; set; }
        public string Error => throw new NotImplementedException();

        //public string City { get; set; }
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
                if (columnName == "City")
                {
                    if (Char.IsUpper(Name[0]) == false)
                    {
                        m = "First letter must be upper";
                    }

                }
                if (columnName == "Mail")
                {
                    if (!Mail.Contains("@"))
                    {
                        m = "Mail must contain @";
                    }
                }
                //switch (columnName)
                //{
                //    case "Login":
                //        if (Login.Contains("bad"))
                //            m = "bad language";
                //        break;
                //}
                return m;
               
            }
        }


    }
}
