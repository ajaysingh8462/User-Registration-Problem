using User_Registration;

namespace Unit_Testing
{
    [TestClass]

    public class UnitTest1
    {
        user_Contact contact = new user_Contact();
        [TestMethod]
        [DataRow("Ajay", "Ajay")]
        [DataRow("Jay", "Jay")]
        [DataRow("a", null)]
        [DataRow("Ajay01", null)]

        public void ValidateUserFirstname(string a, string expected)
        {

            var actual = contact.Firstname(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        [DataRow("Singh", "Singh")]  
        [DataRow("singh", null)]
        [DataRow("Singh05", null)]
        [DataRow("Si", null)]
        public void ValidateUserLastname(string a, string expected)
        {
            var actual = contact.Lastname(a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", null)]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        [DataRow("abc", null)]
        [DataRow("abc@.com.my", null)]
        [DataRow("abc123@.com", null)]
        [DataRow("abc123@.com.com", null)]
        [DataRow("abc()*@gmail.com", null)]
        [DataRow(".abc@abc.com", null)]
        [DataRow("abc@%*.com", null)]
        [DataRow("abc..2002@gmail.com", null)]
        [DataRow("abc.@gmail.com", null)]
        [DataRow("abc@abc@gmail.com", "abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a", null)]
        [DataRow("abc@gmail.com.aa.au", null)]

        public void ValidateUserEmail(string a, string expected)
        {
            var actual = contact.Email(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("91 9842905050", "91 9842905050")]
        [DataRow("100 9842905050", "100 9842905050")]
        [DataRow("919842905050", null)]
        [DataRow("919842905", null)]
        [DataRow("91 984290", null)]
        [DataRow("91 984290505000000", null)]
        public void ValidateUserPhoneNumber(string a, string expected)
        {
            var actual = contact.Number(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Ajay@123", "Ajay@123")]
        [DataRow("Aj#ay123", "Aj#ay123")]
        [DataRow("Singh@ajay1","Singh@ajay1")]
        [DataRow("@Ajay129", "@Ajay129")]
        [DataRow("Ajay-si123", "Ajay-si123")]
        [DataRow("ajay@sin", null)]
        [DataRow("ajay123", null)]
        [DataRow(")ajju12", null)]
        [DataRow("ajay-s@12S", "ajay-s@12S")]
        [DataRow("ajaySI@", null)]

        public void ValidateUserPassword(string a, string expected)
        {
            var actual = contact.Passoword_Rule4(a);
            Assert.AreEqual(expected, actual);
        }
    }
}