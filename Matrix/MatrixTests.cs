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
        public void Transpose3x3MatrixTest()
        {
            var matrix3x3 = "1 2 3\n4 5 6\n7 8 9";

            var streamWriter = new StreamWriter(new MemoryStream());
            streamWriter.Write(matrix3x3);
            streamWriter.Flush();

            _matrix.Read(streamWriter.BaseStream);
            _matrix.Transpose();

            streamWriter.Close();

            var streamReader = new StreamReader(new MemoryStream());
            _matrix.Write(streamReader.BaseStream);
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

            Assert.AreEqual("1 4 7\n2 5 8\n3 6 9", streamReader.ReadToEnd(), "Wrong 3x3 matrix transpose");
            streamReader.Close();
        }

        [Test]
        public void Transpose2x4MatrixTest()
        {
            var matrix2x4 = "1 2 3 4\n5 6 7 8";

            var streamWriter = new StreamWriter(new MemoryStream());
            streamWriter.Write(matrix2x4);
            streamWriter.Flush();

            _matrix.Read(streamWriter.BaseStream);
            _matrix.Transpose();

            streamWriter.Close();

            var streamReader = new StreamReader(new MemoryStream());
            _matrix.Write(streamReader.BaseStream);
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

            Assert.AreEqual("1 5\n2 6\n3 7\n4 8", streamReader.ReadToEnd(), "Wrong 2x4 matrix transpose");
            streamWriter.Close();
        }
    }
}
