using Microsoft.VisualStudio.TestTools.UnitTesting;
using X00073019_EAD_CA3.Pages;

// James Lynam - EAD CA3 - X00073019 - CatUnitTest.cs
// Not much to test here as most methods asynchronous

namespace CatUnitTest
{
    [TestClass]
    public class CatUnitTest
    {

        // Testing object creation
        [TestMethod]
        public void TestObjectCreation()
        {
            Breeds breed1 = new Breeds();
            Cat cat1 = new Cat();
            Categories category1 = new Categories();
        }

        // Testing if Kitty object is passed in successfully
        [TestMethod]
        public void TestFilter()
        {
            Breeds breed1 = new Breeds();
            Breeds.Kitty kitty1 = new Breeds.Kitty();

            breed1.IsVisible(kitty1);
        }
    }
}
