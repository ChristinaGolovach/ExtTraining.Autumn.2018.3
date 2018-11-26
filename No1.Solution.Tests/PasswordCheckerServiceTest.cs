using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using No1.Solution.Validator;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTest
    {
        [Test]
        public void VerifyPassword_EmptyValidator()
        {
            // Arrange
            PasswordCheckerService passwordCheckerService = new PasswordCheckerService(new SqlRepository(), new DefaultEmptyValidator());

            // Act
            (bool, string) result = passwordCheckerService.VerifyPassword("");

            //Assert 
            Assert.AreEqual(false, result.Item1);
            Assert.AreEqual("password is empty", result.Item2);
        }


        [Test]
        public void VerifyPassword_LengthFifteenValidator()
        {
            // Arrange
            PasswordCheckerService passwordCheckerService = new PasswordCheckerService(new SqlRepository(), new LengthFifteenValidator());

            // Act
            (bool, string) result = passwordCheckerService.VerifyPassword("qwertyuiopasdfghjkqw");

            //Assert 
            Assert.AreEqual(false, result.Item1);
            Assert.AreEqual("password length too long", result.Item2);
        }

        [Test]
        public void VerifyPassword_CompositeValidator()
        {
            // Arrange
            IEnumerable<IValidator> validators = new List<IValidator>() { new LengthFifteenValidator()};
            PasswordCheckerService passwordCheckerService = new PasswordCheckerService(new SqlRepository(), new CompositeValidator(validators));

            // Act
            (bool, string) result = passwordCheckerService.VerifyPassword("qwertyuiopasdfghjkqw");

            //Assert 
            Assert.AreEqual(false, result.Item1);
        }
    }
}
