using System;

namespace C_Sharp_Singleton_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection obj = DBConnection.GetOBJ();

            obj.InsertData("Insert Some Data");
        }
    }
}
