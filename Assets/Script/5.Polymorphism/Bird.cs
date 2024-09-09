using UnityEngine;

namespace Script._5.Polymorphism
{
    public class Bird : Animal
    {
        /*
         * Override anahtar kelimesi kalitim alinan sinifta "virtual" anahtar kelimesi ile tanimlanan sanal methodu ezmek yani yeni bir sekil tanimlamak icin kullanilir.Bu sekilde cokbicimlilik ilkesini
         * kullanmis bulnuyoruz.
         */
        internal override void Attack()
        {
            Debug.Log("Birds are cant attack!");
        }
    }
}
