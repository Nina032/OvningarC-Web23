using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    public class SuperPhotoBook : PhotoBook
    {
        public SuperPhotoBook(int numPages)
        {
            this.numPages = numPages;
        }
        public SuperPhotoBook()
        {
            numPages = 64;
        }
    }
}
