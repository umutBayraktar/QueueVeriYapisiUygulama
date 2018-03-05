using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _152802029_2
{
    public class AzOncelikliKuyruk : IKuyruk
    {
        private int front;
        private int size;
        private int count;
        public Musteri []Kuyruk;
        public AzOncelikliKuyruk(int boyut)
        {
            this.size = boyut;
            Kuyruk = new Musteri[this.size];
        }
        public void Insert(Musteri m)
        {
            if (count == size)
            { throw new Exception("Kuyruk Dolu!"); }
            if (IsEmpty())
            {
                front=0;
                Kuyruk[front] = m;
            }
            else
            {
                int i;
                for (i = count - 1; i >= 0; i--)
                {
                    if (m.BeklemeSuresi > Kuyruk[i].BeklemeSuresi)
                    {
                        Kuyruk[i + 1] = Kuyruk[i];
                    }
                    else
                    { break; }
                }
                Kuyruk[i + 1] = m;
                front++;
            }
            count++;
        }
        public bool IsEmpty()
        {
            return (count == 0);
        }

        public Musteri Peek()
        {
            Musteri temp = Kuyruk[front];
            return temp;
        }

        public Musteri Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Kuyruk Boş1");
            }
            Musteri temp = Kuyruk[front];
            Kuyruk[front] = null;
            front--;
            count--;
            return temp;
        }
    }
}
