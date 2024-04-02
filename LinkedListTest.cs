using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Tests
{

    using NUnit.Framework;
    [TestFixture]
    public class LinkedListTest
    {
        private ILinkedListADT users;

        [SetUp]
        public void SetUp()
        {
            //this.users = new SLL();

            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            users.AddLast(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"));
        }

        [TearDown]
        public void TearDown()
        {
            users.Clear();
        }

        [Test]
        public void TestEmpty()
        {
            if (users.Count() == 0)
            {
                Assert.IsTrue(users.IsEmpty());
            }
        }

        [Test]
        public void TestPrepend()
        {
            User expectedUser = new User(0, "Average Joe", "joever@gmail.com", "12345");
            users.AddFirst(expectedUser);
            User testUser = users.GetValue(0);

            Assert.AreEqual(expectedUser, testUser);
        }

        [Test]
        public void TestInsert()
        {
            User expectedUser = new User(0, "Average Joe", "joever@gmail.com", "12345");
            users.Add(expectedUser, 2);
            User testUser = users.GetValue(2);

            Assert.AreEqual(expectedUser, testUser);
        }

        [Test]
        public void TestRemoveFirst()
        {
            User expectedUser = users.GetValue(1);
            users.RemoveFirst();
            User testUser = users.GetValue(0);

            Assert.AreEqual(expectedUser, testUser);
        }

        [Test]
        public void TestRemove()
        {
            User expectedUser = users.GetValue(2);
            users.Remove(1);
            User testUser = users.GetValue(1);

            Assert.AreEqual(expectedUser, testUser);
        }
    }
}
