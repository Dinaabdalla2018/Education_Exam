using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quize.DAL.Models.ViewModel
{
    public class SignUpViewModel
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string password { set; get; }
        public string Repassword { set; get; }
    }
}
