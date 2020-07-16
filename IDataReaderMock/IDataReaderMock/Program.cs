using System;

namespace IDataReaderMock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FakeClass fake = new FakeClass();
            fake.readData();


        }
    }
}
