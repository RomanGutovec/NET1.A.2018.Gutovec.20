using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No1.Solution.Interfaces;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IRepository repository;
        private IVerify condition;

        public PasswordCheckerService(IRepository repository, IVerify condition)
        {
            this.repository = repository ?? throw new ArgumentNullException($"Repository {nameof(repository)} has null value");
            this.condition = condition ?? throw new ArgumentNullException($"Condition {nameof(repository)} has null value");
        }

        public (bool, string) VerifyPassword(string password)
        {
            if (condition.Verify(password))
            {
                repository.Create(password);
                return (true, condition.Message);
            }

            return (false, "Password is invalid. TryAgain");
        }
    }
}
