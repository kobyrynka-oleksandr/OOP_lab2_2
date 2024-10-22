using OOP_lab2_2;
namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test_ToStringWithIntPart()
        {
            long nom = 12;
            long denom = 5;

            string expected = "(2+2/5)";

            MyFrac frac = new MyFrac(nom, denom);
            string result = frac.ToStringWithIntPart();

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Test_DoubleValue()
        {
            long nom = 18;
            long denom = 4;

            double expected = 4.5;

            MyFrac frac = new MyFrac(nom, denom);
            double result = frac.DoubleValue();

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Test_Plus()
        {
            long nom1 = 13;
            long denom1 = 3;

            long nom2 = 15;
            long denom2 = 12;

            string expected = "(67/12)";

            MyFrac frac1 = new MyFrac(nom1, denom1);
            MyFrac frac2 = new MyFrac(nom2, denom2);
            MyFrac result = frac1 + frac2;

            Assert.AreEqual(expected, result.ToString());
        }
        [Test]
        public void Test_Minus()
        {
            long nom1 = 13;
            long denom1 = 3;

            long nom2 = 15;
            long denom2 = 12;

            string expected = "(37/12)";

            MyFrac frac1 = new MyFrac(nom1, denom1);
            MyFrac frac2 = new MyFrac(nom2, denom2);
            MyFrac result = frac1 - frac2;

            Assert.AreEqual(expected, result.ToString());
        }
        [Test]
        public void Test_Multiply()
        {
            long nom1 = 13;
            long denom1 = 3;

            long nom2 = 15;
            long denom2 = 12;

            string expected = "(65/12)";

            MyFrac frac1 = new MyFrac(nom1, denom1);
            MyFrac frac2 = new MyFrac(nom2, denom2);
            MyFrac result = frac1 * frac2;

            Assert.AreEqual(expected, result.ToString());
        }
        [Test]
        public void Test_Divide()
        {
            long nom1 = 13;
            long denom1 = 3;

            long nom2 = 15;
            long denom2 = 12;

            string expected = "(52/15)";

            MyFrac frac1 = new MyFrac(nom1, denom1);
            MyFrac frac2 = new MyFrac(nom2, denom2);
            MyFrac result = frac1 / frac2;

            Assert.AreEqual(expected, result.ToString());
        }
        [Test]
        public void Test_CalcExpr1()
        {
            int n = 10;

            string expected = "(10/11)";

            MyFrac frac = new MyFrac(1, 1);
            MyFrac result = frac.CalcExpr1(n);

            Assert.AreEqual(expected, result.ToString());
        }
        [Test]
        public void Test_CalcExpr2()
        {
            int n = 10;

            string expected = "(11/20)";

            MyFrac frac = new MyFrac(1, 1);
            MyFrac result = frac.CalcExpr2(n);

            Assert.AreEqual(expected, result.ToString());
        }
    }
}