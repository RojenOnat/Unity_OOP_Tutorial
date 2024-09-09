using UnityEngine;

namespace Script._5.Polymorphism
{
    public class Animal
    {

        /*
    * Tanim: Polimorfizm, ayni isimdeki methodlari farkli siniflar tarafindan farkli sekilde uygulanmasini saglar.
    * Bu, bir sinif hiyerarsisindeki siniflarin ortak bir methodu kendi ihtiyaclarina gore degistirmesini mumkun kilar.
      Kullanim: Unity'de, oyun karakterlerinin ayni methodlari farkli sekilde uygulamasini saglar.
       Ornegin, "Bird" ve "Dog" sinifi bir Attack() methoduna sahip olabilir, ama farkli saldiri davranislara sahip olabilirler.
       Bunun icin methodlar "virtual" anahtar kelimesini kullanarak ezilebilen/sanal bir method haline donusurler.
       Virtual anahtarinda daha fazla bilgi icin : (https://learn.microsoft.com/tr-tr/dotnet/csharp/language-reference/keywords/virtual ) 
    */
        internal virtual void Attack()
        {
            Debug.Log("Attack process is working.");
        }

    }
}
