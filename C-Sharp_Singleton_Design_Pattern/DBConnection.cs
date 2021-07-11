using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace C_Sharp_Singleton_Design_Pattern
{
    internal class DBConnection
    {
        private static DBConnection obj = null;

        private DBConnection() //DataBase Connection Singleton prevents the instantiation from any other class.
        {
            try
            {
                //Connecting to a Database
                Console.WriteLine("Successfully connected to the Database");

            }catch (Exception ex)
            {
                //Catch errors
                Debug.WriteLine(ex.Message);
            }
        }

        public static DBConnection GetOBJ() //Saves memory because object is not created at each request. Only single instance is reused again and again.
        {
            if(obj == null)
            {
                lock(new object())
                {
                    if(obj == null)
                    {
                        obj = new DBConnection(); //instance will be created at request time 
                    }
                }
            }

            return obj;
        }

        public void InsertData(string query)
        {
            try
            {
                //to insert the record into the database
                Console.WriteLine(query);
            }catch (Exception ex)
            {
                //Catch errors
                Debug.WriteLine(ex.Message);
            }
            
        }
    }
}
