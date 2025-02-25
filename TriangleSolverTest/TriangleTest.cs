using NUnit.Framework;
using TriangleSolver; // Reference the main project

namespace TriangleSolverTest
{
    [TestFixture]
    public class TriangleTest
    {
        // 1. Valid Equilateral Triangle
        [Test]
        public void AnalyzeTriangle_EquilateralTriangle_ReturnsEquilateral()
        {
            var result = Triangle.AnalyzeTriangle(5, 5, 5);
            Assert.That(result, Is.EqualTo("Equilateral triangle"));
        }


         // 2-4. Valid Isosceles Triangles
        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle1_ReturnsIsosceles()
        {
            var result = Triangle.AnalyzeTriangle(5, 5, 3);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle2_ReturnsIsosceles()
        {
            var result = Triangle.AnalyzeTriangle(7, 7, 10);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle3_ReturnsIsosceles()
        {
            var result = Triangle.AnalyzeTriangle(6, 6, 4);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }


           // 5-9. Valid Scalene Triangles
        [Test]
        public void AnalyzeTriangle_ScaleneTriangle1_ReturnsScalene()
        {
            var result = Triangle.AnalyzeTriangle(3, 4, 5);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle2_ReturnsScalene()
        {
            var result = Triangle.AnalyzeTriangle(6, 8, 10);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle3_ReturnsScalene()
        {
            var result = Triangle.AnalyzeTriangle(7, 9, 12);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle4_ReturnsScalene()
        {
            var result = Triangle.AnalyzeTriangle(5, 7, 9);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle5_ReturnsScalene()
        {
            var result = Triangle.AnalyzeTriangle(11, 14, 15);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

    }
}