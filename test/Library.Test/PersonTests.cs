using NUnit.Framework;
using UnitTestAndDebug;


namespace Tests
{
    public class Tests
    {
        [Test]
        public void IdIsValidTest() // cedula valida
        {
            bool result = IdUtils.IdIsValid("51610313");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IdIsValidTest2() // puntos y guiones
        {
            bool result = IdUtils.IdIsValid("5.161.031-3");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IdIsValidTest3() // numero del string
        {
            bool result = IdUtils.IdIsValid("5.161.031-3");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IdIsValidTest4() // cedula invalida
        {
            bool result = IdUtils.IdIsValid("8.765.432-1");
            Assert.AreEqual(false, result);
        }

        [Test]
        public void NameTest1() // nombre valido
        {
            Person Franco = new Person("Franco Robotti", "5.161.031-3");

            string result = Franco.Name;

            Assert.AreEqual("Franco Robotti",result);
        }

        public void NameTest2() // nombre vacio
        {
            Person Franco = new Person("", "5.161.031-3");

            string result = Franco.Name;

            Assert.AreEqual("",result);
        }
    }
}