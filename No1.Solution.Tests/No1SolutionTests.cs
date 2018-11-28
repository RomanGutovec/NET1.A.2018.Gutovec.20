using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No1.Solution.ConditionalsVerify;
using No1.Solution.Interfaces;
using NUnit.Framework;


namespace No1.Solution.Tests
{
    [TestFixture]
    public class No1SolutionTests
    {
        [Test]
        public void DifferentConditionalTets()
        {
            string password = "12345678901234567890";

            List<IVerify> conditions = new List<IVerify>
            {
                new CheckEmpty(),
                new CheckContainsDigit(),
                new CheckLengthTooBig()
            };
            var combination = new CompositeConditions(conditions);

            PasswordCheckerService service = new PasswordCheckerService(new SqlRepository(), combination);
            Assert.IsFalse(service.VerifyPassword(password).Item1);
        }
    }
}
