using NUnit.Framework;
using System.IO;

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
        public void TransposeTest()
        {
            var initialMatrix = "1 2 3\n4 5 6\n7 8 9";

            var streamWriter = new StreamWriter(new MemoryStream());
            streamWriter.Write(initialMatrix);

            _matrix.Read(streamWriter.BaseStream);
            _matrix.Transpose();

            streamWriter.Close();

            var streamReader = new StreamReader(new MemoryStream());
            _matrix.Read(streamReader.BaseStream);

            Assert.AreEqual("1 4 7\n2 5 8\n3 6 9", streamReader.ReadToEnd(), "Wrong 3x3 matrix transpose");
        }
    }
}
