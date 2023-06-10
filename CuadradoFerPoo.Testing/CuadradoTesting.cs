using CuadradoFerPoo.Entidades;

namespace CuadradoFerPoo.Testing
{
    [TestClass]
    public class CuadradoTesting
    {
        [TestMethod]
        public void CuadradoValidarValida()
        {
            int medidaLado = 10;
            Cuadrado c = new Cuadrado(medidaLado);
            Assert.IsTrue(c.Validar());
        }
        [TestMethod]
        public void CuadradoValidarNoValida()
        {
            int medidaLado = -10;
            Cuadrado c=new Cuadrado(medidaLado);
            Assert.IsFalse(c.Validar());
        }

        [TestMethod]
        public void CuadradoGetPerimetro()
        {
            int medidaLado = 10;
            Cuadrado c = new Cuadrado(medidaLado);
            Assert.AreEqual(40, c.GetPerimetro());
        }
        [TestMethod]
        public void CuadradoGetSuperficie()
        {
            int medidaLado = 10;
            Cuadrado c = new Cuadrado(medidaLado);
            Assert.AreEqual(100, c.GetSuperficie());
        }
    }
}