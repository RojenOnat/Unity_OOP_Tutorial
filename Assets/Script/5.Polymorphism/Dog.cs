using UnityEngine;

namespace Script._5.Polymorphism
{
    public class Dog : Animal
    {
        internal override void Attack()
        {
            //base anahtar kelimesi ile kalitim aldigimiz siniftaki methodu calistiririz ve sonrasinda yeni tanimlayacagimiz ozellikleri calistirmamizi saglar.
            //konsolumuzda ilk olarak "Attack process is working" yazisini gorecegiz ve ardindan bu sinif icin tanimladigimiz yeni ozelliklerimizi gorecegiz.
            base.Attack();
            
            Debug.Log("Dogs are can attack!");
        }
    }
}
