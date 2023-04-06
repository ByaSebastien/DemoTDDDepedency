using DemoTDDDepedency.BLL.Interfaces;
using DemoTDDDepedency.BLL.Services;
using DemoTDDDepedency.BLL.Test.Mocks;
using DemoTDDDepedency.DAL.Interfaces;
using DemoTDDDepedency.Models;

namespace DemoTDDDepedency.BLL.Test.Services
{
    [TestClass]
    public class PersonServiceTest
    {
        [TestMethod]
        [DataRow(1,"Bulbizare")]
        [DataRow(2,"Ratata")]
        [DataRow(3,"Mr Mime")]
        [DataRow(4,"Mew")]
        [DataRow(5,null)]
        public void GetById(int id, string? expectedFirstName)
        {
            //Arrange
            IPersonService personService = new PersonService(new PersonRepositoryMock());

            //Action
            string? actual = personService.GetById(id)?.FirstName;

            //Assert
            Assert.AreEqual(expectedFirstName, actual);
        }

        [TestMethod]
        [DataRow("Bulbizare",1)]
        [DataRow("Dis n'importe quoi",2)]
        [DataRow("Mr Mime",3)]
        [DataRow("Mew",4)]
        [DataRow("toto",null)]
        public void GetByName(string name, int? expectedId)
        {
            //Arrange
            IPersonService personService = new PersonService(new PersonRepositoryMock());

            //Action
            int? actual = personService.GetByName(name)?.Id;

            //Assert
            Assert.AreEqual(expectedId, actual);
        }

        [TestMethod]
        public void GetAll()
        {
            //Assert
            IPersonService personService = new PersonService(new PersonRepositoryMock());
            string expectedFirstNameBulbizare = "Bulbizare";
            string expectedFirstNameMew = "Mew";
            string expectedLastName = "La feuille";
            int expectedCount = 4;

            //Action
            IEnumerable<Person> people = personService.GetAll();

            //Assert
            Assert.IsTrue(people.Any(p => p.FirstName == expectedFirstNameBulbizare));
            Assert.IsTrue(people.Any(p => p.FirstName == expectedFirstNameMew));
            Assert.IsTrue(people.Any(p => p.LastName == expectedLastName));
            Assert.AreEqual(expectedCount, people.Count());

        }
    }
}