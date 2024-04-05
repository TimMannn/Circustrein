using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace Circustrein.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void casetest1()
        {
            // Arrange
            Trein trein = new Trein();

            // Act
            Form1 form1 = new Form1();
            trein.FillWagon(0, 0, 1, 2, 3, 0, form1);

            // Assert
            Assert.AreEqual(2, trein.WagonCount);

        }

        [TestMethod]
        public void casetest2()
        {
            // Arrange
            Trein trein = new Trein();

            // Act
            Form1 form1 = new Form1();
            trein.FillWagon(0, 0, 1, 1, 2, 5, form1);

            // Assert
            Assert.AreEqual(2, trein.WagonCount);

        }

        [TestMethod]
        public void casetest3()
        {
            // Arrange
            Trein trein = new Trein();

            // Act
            Form1 form1 = new Form1();
            trein.FillWagon(1, 1, 1, 1, 1, 1, form1);

            // Assert
            Assert.AreEqual(4, trein.WagonCount);
        }

        [TestMethod]
        public void casetest4()
        {
            // Arrange
            Trein trein = new Trein();

            // Act
            Form1 form1 = new Form1();
            trein.FillWagon(2, 1, 1, 1, 5, 1, form1);

            // Assert
            Assert.AreEqual(5, trein.WagonCount);
        }

        [TestMethod]
        public void casetest5()
        {
            // Arrange
            Trein trein = new Trein();

            // Act
            Form1 form1 = new Form1();
            trein.FillWagon(0, 0, 1, 2, 1, 1, form1);

            // Assert
            Assert.AreEqual(2, trein.WagonCount);
        }

        [TestMethod]
        public void casetest6()
        {
            // Arrange
            Trein trein = new Trein();

            // Act
            Form1 form1 = new Form1();
            trein.FillWagon(0, 0, 3, 3, 2, 0, form1);

            // Assert
            Assert.AreEqual(3, trein.WagonCount);
        }

        [TestMethod]
        public void casetest7()
        {
            // Arrange
            Trein trein = new Trein();

            // Act
            Form1 form1 = new Form1();
            trein.FillWagon(3, 3, 7, 6, 5, 0, form1);

            // Assert
            Assert.AreEqual(13, trein.WagonCount);
        }
    }
}