using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace СalculatingTheArea.Tests
{
    [TestClass()]
    public class CalculatingTheAreaTest
    {
        [TestMethod()]
        public void GetAreaCircle_2_return_4PI()
        {
            double radius = 2.0;
            double expected = 4 * Math.PI;

            Circle c = FigureFactory.CreateCircle(radius);
            double actual = c.GetArea();

            Assert.AreEqual(expected, actual, 0.0001);

        }

        [TestMethod()]
        public void CreateCircle_3_return_not_null()
        {
            double radius = 3.0;

            Assert.IsNotNull(FigureFactory.CreateCircle(radius));

        }

        [TestMethod()]
        public void CreateCircle_input_negative_Radius_return_null()
        {
            double radius = -1.0;

            Assert.IsNull(FigureFactory.CreateCircle(radius));

        }

        [TestMethod()]
        public void GetAreaTriangle_3and4and5_return_6()
        {
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 5.0;
            double expected = 6.0;

            Triangle t = FigureFactory.CreateTriangle(side1, side2, side3);
            double actual = t.GetArea();

            Assert.AreEqual(expected, actual, 0.0001);

        }

        [TestMethod()]
        public void CreateTriangle_input_negative_side_return_null()
        {
            double side1 = 3.0;
            double side2 = -4.0;
            double side3 = 5.0;

            Assert.IsNull(FigureFactory.CreateTriangle(side1, side2, side3));

        }

        [TestMethod()]
        public void CreateTriangle_input_noncorrect_sides_return_null()
        {
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 8.0;

            Assert.IsNull(FigureFactory.CreateTriangle(side1, side2, side3));

        }


        [TestMethod()]
        public void CreateTriangle_3and4and5_return_not_null()
        {
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 5.0;

            Assert.IsNotNull(FigureFactory.CreateTriangle(side1, side2, side3));

        }
        
        [TestMethod()]
        public void IsRectangular_6and8and10_return_true()
        {
            double side1 = 6.0;
            double side2 = 8.0;
            double side3 = 10.0;

            Triangle t = FigureFactory.CreateTriangle(side1, side2, side3);
            Assert.IsTrue(t.IsRectangular());   
        }

        [TestMethod()]
        public void IsRectangular_7and8and9_return_false()
        {
            double side1 = 7.0;
            double side2 = 8.0;
            double side3 = 9.0;

            Triangle t = FigureFactory.CreateTriangle(side1, side2, side3);
            Assert.IsFalse(t.IsRectangular());

        }

    }
}
