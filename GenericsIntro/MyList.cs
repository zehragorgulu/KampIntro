using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>  // programcı hangi tipi new'lerse onu kullansın
    {
        T[] items;                 //listeler arkaplandaki bir arrayi yönetir biz de array veriyoruz

        // constructor  -> newlediğimiz anda çaışan bloktur, class ile aynı isimde
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;  // geçici dizinin referansı = items'in referansı
            items = new T[items.Length+1]; // dizinin eleman sayısını 1 arttırdık, newlediğimiz için referans
                                           // numarasını kaybedecektik ama geçici dizi ile safe'e aldık
            for (int i = 0; i < tempArray.Length; i++) // temparray'in elemanlarını items'e geri atayacağız
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1 ] = item;   //son eleman kısmına item elemanını ekledik
        }
    }
}
