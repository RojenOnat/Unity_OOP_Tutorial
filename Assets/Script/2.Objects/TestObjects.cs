using System;
using UnityEngine;

namespace Script._2.Objects
{
    public class TestObjects : MonoBehaviour
    {
       
        public void Start()
        {
            Car car = new Car();  // Car sinifindan bir nesne olusturduk.
            
            /*
             * Tanim: Nesneler, siniflarin gercek dünyadaki karsiligidir. Sinif, bir nesnenin planiyken, nesne o siniftan tureyen somut bir varliktir.
               Kullanim: Unity'de her oyun varligi, bir sinifin ornegidir (instance) olan bir nesnedir.
               Car sinifindan burada "car" adindan bir somut yani oyun icinde kullanabilecegimiz bir nesne olusturduk.
             */
        }
    }
}
