


/*
 * Tanim: Soyutlama, gereksiz detaylari gizleyip sadece önemli bilgileri gösterme prensibidir. Bu, siniflarin ve nesnelerin karmasikligini azaltir.
   Kullanim: Unity'de, oyun varliklarinin nasıl calistigi detaylarini gizleyip sadece temel islevlerini aciga cikarabiliriz.
   Bir sinif sadece bir abstract sınıftan miras alabilir.
   Kullanilacagi siniflarda "override" anahtar kelimesi ile tanimlanirlar.
   Soyut varliklar olarak düsenebiliriz ve bu soyut varliklardan nesne uretemeyiz.Bu varliklarda gercek dunyada kullanamayacagimiz verileri tasiriz.
   Abstract kelimesi ile isaretlenmis bir method muhakkak kullanildigi yerde ici doldurulmalidir.
 */
namespace Script._6.Abstraction
{
    public abstract class Character
    {
        protected Character()
        {
            Move();
        }
        public abstract int MoveSpeed { get; set; }

        public abstract void Move();

    }
}
