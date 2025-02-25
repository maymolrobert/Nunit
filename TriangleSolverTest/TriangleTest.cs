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

    }
}