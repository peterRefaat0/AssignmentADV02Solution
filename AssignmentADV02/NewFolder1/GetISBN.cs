using AssignmentADV02.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV02.NewFolder1
{
    public class GetISBN
    {

        public class LibraryEngine
        {
            public static void ProcessBooks(List<Book> blist, Func<object, object> value)
            {
                Func<Book, string> getISBN = delegate (Book B)
                {
                    return B.ISBN;
                };

                foreach (Book B in blist)
                {
                    Console.WriteLine(getISBN(B));
                }
            }
        }



    }
}
