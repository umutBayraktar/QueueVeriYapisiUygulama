using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _152802029_2
{
   public  interface IKuyruk
    {
        void Insert(Musteri m);
        Musteri Remove();
        Musteri Peek();
        bool IsEmpty();

    }
}
