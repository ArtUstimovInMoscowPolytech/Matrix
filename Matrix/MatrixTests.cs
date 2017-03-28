using NUnit.Framework;

namespace Matrix
{
    [TestFixture]
    class MatrixTests
    {
        private IMatrix _matrix;

        [SetUp]
        public void SetUp()
        {
            // Create matrix
        }

        [Test]
        public void Transpose3x3MatrixTest()
        {
            var matrix3x3 = "1 2 3\n4 5 6\n7 8 9";

            _matrix.Read(matrix3x3);
            _matrix.Transpose();
            
            var transposedMatrix = _matrix.Write();

            Assert.AreEqual("1 4 7\n2 5 8\n3 6 9", transposedMatrix, "Wrong 3x3 matrix transpose");
        }

        [Test]
        public void Transpose2x4MatrixTest()
        {
            var matrix2x4 = "1 2 3 4\n5 6 7 8";

            _matrix.Read(matrix2x4);
            _matrix.Transpose();

            var transposedMatrix = _matrix.Write();

            Assert.AreEqual("1 5\n2 6\n3 7\n4 8", transposedMatrix, "Wrong 2x4 matrix transpose");
        }

        [Test]
        public void WriteTest()
        {
            var matrix2x2 = "1 2\n3 4";

            _matrix.Read(matrix2x2);

            var matrix = _matrix.Write();

            Assert.AreEqual(matrix2x2, matrix, "Wrong write");
        }
    }
}
