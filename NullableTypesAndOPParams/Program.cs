using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypesAndOPParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classes (including strings) don't have to be nullable.
            //They accept null by default.
            Person gui = null;
            string someInput = null;

            //Nullable types
            int myInt = 1;
            int? myIntNull = null;
            decimal? myDecimal = null;
            bool? myBool = null;
            double? myDouble = null;

            //Calling method with optional parameters
            DoAnotherWork("name1");
            DoAnotherWork("name2", 3);
            DoAnotherWork("name3", 4);

        }

        /// <summary>
        /// Method with nullable parameters
        /// </summary>
        /// <param name="myInt"></param>
        static void DoSomeWork(int? myInt)
        {   
            //Same check as below (.HasValue)
            if (myInt != null)
            {
                
            }

            //Same check as above (!= null)
            if (myInt.HasValue)
            {
                
            }

            //Get the value from the nullable type
            var myOtherInt = myInt.Value;
        }

        /// <summary>
        /// Method with optional parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="myInt"></param>
        static void DoAnotherWork(string name, int myInt = 1 )
        {

        }
    }
}
