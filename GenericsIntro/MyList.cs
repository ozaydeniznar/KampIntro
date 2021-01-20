using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // veri tipini T(type) ver demek aşağıdakileride ona göre yapılandıracağım demek yani.
    // ben sana ne veriyorsam istediğim eleman türüde odur (T)
    // string T olarak tanımladığın için string yazmana gerek yok.
    class MyList<T>
    {
        T[] items;

        //Constructor - Class' ı  new ' lersen auto çalışır.
        //array referans tip olduğu için onu new' leme zorunluluğu var.
        public MyList()
        {
            items = new T[0];
        }

        //Lenght - tüm sayıları verir.
        // new yaptığımız için referans numarası gider o yüzden bi yere tutturmak gerek.
        //tempArray - Geçiçi Array
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;


            //1 elemanlı yeni bir dize oluştu ( lenght ne 0 sende +1 yaptın 1 elemanlı dize oluştu
            //daha önce eklediğin değer gide runutma (stack, heap ) bunun içinde tempArray diyoruz geçici değer oluştur benim değerimi tut ben unutmayım diye mantık bu şekilde işler.
            // for ' ben sana emanetten değer verdim sende onları bana geri versene diyorsun. ( yani değerler yine aynı şekilde orda kalıyor)
            // items[items.Length - 1] = item; ( Add T item) son itemi boş kalan yere ekledik. 
        }
    }
}
