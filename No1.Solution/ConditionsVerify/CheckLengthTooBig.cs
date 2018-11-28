using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No1.Solution.Interfaces;

namespace No1.Solution.ConditionalsVerify
{
    public class CheckLengthTooBig : IVerify
    {       
        private string message = "Password is Ok. User was created";

        public string Message => message;

        public bool Verify(string password)
        {
            if (password.Length >= 15)
            {
                message = $"{password} length too long";
                return false;
            }

            return true;
        }
    }
}
