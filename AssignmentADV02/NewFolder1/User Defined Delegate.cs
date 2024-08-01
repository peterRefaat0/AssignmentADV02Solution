using AssignmentADV02.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV02.NewFolder1
{
    public class User_Defined_Delegate
    {


        public delegate string BookFunctionDelegate(Book B);

        public class LibraryEngine
        {
            public static void ProcessBooks(List<Book> blist, BookFunctionDelegate fPtr)
            {
                foreach (Book B in blist)
                {
                    Console.WriteLine(fPtr(B));
                }
            }
        }



    }
}
