using System.IO;

namespace Matrix
{
    interface IMatrix
    {
        void Read(Stream stream);
        void Write(Stream stream);
        void Transpose();
    }
}
