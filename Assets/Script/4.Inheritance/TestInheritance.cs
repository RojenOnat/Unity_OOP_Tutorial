using System;
using UnityEngine;

namespace Script._4.Inheritance
{
    public class TestInheritance : MonoBehaviour
    {
        private Sword _sword;
        private Bow _bow;
        void Start()
        {
             _sword = new Sword(15, "sword",1);
             _bow = new Bow(10, "bow", 2);
            //sword ve bow adinda oyun icinde kullanabilecegimiz bir nesne olusturduk.Weapon sinifindan miras aldigimiz icin bu sinifin icerisindeki methodlari ve ozellikleri artik tasiyoruz.
            //WeaponName,AttackSpeed,Damage degiskenlerini tekrar tanimlamamiza gerek kalmadi,boylelikle kod tekrarini ve karisikligi onlemis olmakla birlikte bir hiyerarsi olusturabildik.
            //Daha kapsamli projelerde 10-20 silah tipi oldugu vakit her silah icin ayri ayri bunlari tanimlamamiza gerek kalmadi ve degistirecegimiz zaman kolaylikla mudahale etmemize olanak sagladik.
        }

     
    }
}
