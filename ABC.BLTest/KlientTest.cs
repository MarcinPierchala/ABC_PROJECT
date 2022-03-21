using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC.BLTest
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            //Arrange
            Klient klient = new Klient();
            klient.Imie = "Marcin";
            klient.Nazwisko = "Pierchala";
            string wartoscOczekiwana = "Marcin, Pierchala";
            //ACT
            string aktualnaWartosc = klient.ImieNazwisko;
            //Assert
            Assert.AreEqual(wartoscOczekiwana, aktualnaWartosc);
        }

        [TestMethod]
        public void ImieNazwiskoImiePuste()
        {
            //Arrange
            Klient klient = new Klient();
            klient.Nazwisko = "Pierchala";
            string wartoscOczekiwana = "Pierchala";
            //ACT
            string aktualnaWartosc = klient.ImieNazwisko;
            //Assert
            Assert.AreEqual(wartoscOczekiwana, aktualnaWartosc);
        }

        [TestMethod]
        public void ImieNazwiskoNazwiskoPuste()
        {
            //Arrange
            Klient klient = new Klient();
            klient.Imie = "Marcin";
            string wartoscOczekiwana = "Marcin";
            //ACT
            string aktualnaWartosc = klient.ImieNazwisko;
            //Assert
            Assert.AreEqual(wartoscOczekiwana, aktualnaWartosc);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            Klient klient1 = new Klient();
            klient1.Imie = "Marcin";
            Klient.Counter += 1;

            Klient klient2 = new Klient();
            klient2.Imie = "Rafa³";
            Klient.Counter += 1;

            Klient klient3 = new Klient();
            klient3.Imie = "Adian";
            Klient.Counter += 1;

            //ACT

            //Assert
            Assert.AreEqual(3, Klient.Counter);
        }

        [TestMethod]
        public void ZwalidujTest()
        {
            //Arrange
            var klient = new Klient();
            klient.Nazwisko = "Pierchla";
            klient.Email = "macintecmarcin@gmail.com";
            var wartoscOczekiwana = true;

            //ACT
            var aktualnaWartosc = klient.Zwaliduj();

            //Assert
            Assert.AreEqual(wartoscOczekiwana, aktualnaWartosc);
        }

        [TestMethod]
        public void ZwalidujNazwiskoPuste()
        {
            //Arrange
            var klient = new Klient();
            klient.Email = "macintecmarcin@gmail.com";
            var wartoscOczekiwana = false;

            //ACT
            var aktualnaWartosc = klient.Zwaliduj();

            //Assert
            Assert.AreEqual(wartoscOczekiwana, aktualnaWartosc);
        }

        [TestMethod]
        public void ZwalidujEmailPusty()
        {
            //Arrange
            var klient = new Klient();
            klient.Nazwisko = "Pierchala";
            var wartoscOczekiwana = false;

            var klient1 = new Klient(100);
            var klient2 = new Klient();


            //ACT
            var aktualnaWartosc = klient.Zwaliduj();

            //Assert
            Assert.AreEqual(wartoscOczekiwana, aktualnaWartosc);
        }
    }
}