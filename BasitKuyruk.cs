using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _152802029_2
{
    public class BasitKuyruk : IKuyruk

    {

        Musteri []Kuyruk;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public BasitKuyruk(int boyut )
        {
            this.size = boyut;
            Kuyruk = new Musteri[this.size];
        }
        public void Insert(Musteri m)
        {
            if ((count == size))
              { throw new Exception("Kuyruk Dolu!"); }
            if (front == -1)
              { front = 0; }
            if (rear == size - 1)
            {
                rear = 0;
                Kuyruk[rear] = m;
            }
            Kuyruk[++rear] = m;
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
            int i = front;
            if (IsEmpty())
            {
                throw new Exception("Kuyruk Boş!");
            }
            Musteri temp = Kuyruk[front];
            Kuyruk[front] = null;
            if (front == size - 1)
              { front = 0; }
            else
              { front++; }
            count--;
            return temp;
        }
    }
}
