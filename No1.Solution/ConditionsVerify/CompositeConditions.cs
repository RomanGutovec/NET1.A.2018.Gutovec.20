using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No1.Solution.Interfaces;

namespace No1.Solution.ConditionalsVerify
{
    public class CompositeConditions : IVerify
    {
        private string message = "Password is Ok. User was created";
        private IEnumerable<IVerify> conditions;
        
        public CompositeConditions(IEnumerable<IVerify> conditions)
        {
            this.conditions = conditions ?? throw new ArgumentNullException($"Conditions {nameof(conditions)} has null value");
        }

        public string Message => message;

        public bool Verify(string password)
        {
            StringBuilder messages = new StringBuilder();
            foreach (var item in conditions)
            {
                messages.AppendFormat($"Message: {item}/n");
            }

            return conditions.All(x => x.Verify(password));
        }
    }
}
