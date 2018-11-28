using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No1.Solution.Interfaces;

namespace No1.Solution.ConditionalsVerify
{
    public class CheckContainsDigit : IVerify
    {
        private string message = "Password is Ok. User was created";

        public string Message => message;

        public bool Verify(string password)
        {
            if (!password.Any(char.IsNumber))
            {
                message = $"{password} hasn't digits";
                return false;
            }

            return true;
        }
    }
}
