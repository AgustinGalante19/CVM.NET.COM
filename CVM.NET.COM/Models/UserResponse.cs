using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVM.NET.COM.Models
{

    public class UserResponse
    {
        public string odatacontext { get; set; }
        public object[] businessPhones { get; set; }
        public string displayName { get; set; }
        public string givenName { get; set; }
        public object jobTitle { get; set; }
        public object mail { get; set; }
        public object mobilePhone { get; set; }
        public object officeLocation { get; set; }
        public string preferredLanguage { get; set; }
        public string surname { get; set; }
        public string userPrincipalName { get; set; }
        public string id { get; set; }
    }

}
