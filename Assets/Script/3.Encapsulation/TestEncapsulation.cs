using System;
using System.Collections;
using System.Collections.Generic;
using Script._3.Encapsulation;
using UnityEngine;

public class TestEncapsulation : MonoBehaviour
{
    private Gold _gold;

    private void Start()
    {
        //private olarak isaretledigimiz icin bizim _gold adini verdigimiz nesnenin icini doldurmamiz lazim ki kullanabilelim.Bundan oturu _gold nesnemizi Gold sinifindan tanimliyoruz. 
        _gold = new Gold();
        //artik _gold nesnemiz Gold sinifi ile isaretlendi.Yani bu Gold sinifimizin ozelliklerini istedigimiz gibi kullanabilecegimiz anlamina geliyor.
        
        _gold.SetCurrentGoldAmount(10);
    }
}
