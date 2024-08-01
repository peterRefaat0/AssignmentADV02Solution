using AssignmentADV02.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV02.NewFolder1
{
    public class Built_in_Delegate
    {
        public class LibraryEngine
        {
            public static void ProcessBooks(List<Book> blist, Func<Book, string> fPtr)
            {
                foreach (Book B in blist)
                {
                    Console.WriteLine(fPtr(B));
                }
            }
        }



    }
}
