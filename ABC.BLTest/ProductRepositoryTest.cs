using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABC.BL;

namespace ABC.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void PobierzProdukt()
        {
            var productRepository = new ProductRepository();
            var oczekiwanaWartosc = new Produkt(2)
            {
                NazwaProduktu = "Klocki",
                Opis = "LEGO, NR_98765",
                AktualnaCena = 987.65M
            };

            var aktualnaWartosc = productRepository.Pobierz(2);

            Assert.AreEqual(oczekiwanaWartosc.AktualnaCena, aktualnaWartosc.AktualnaCena);
            Assert.AreEqual(oczekiwanaWartosc.Opis, aktualnaWartosc.Opis);
            Assert.AreEqual(oczekiwanaWartosc.NazwaProduktu, aktualnaWartosc.NazwaProduktu);

        }
    }
}
