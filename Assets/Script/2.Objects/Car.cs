using UnityEngine;

namespace Script._2.Objects
{
    public class Car
    {
        private readonly string _modelName = "BMW";
        private readonly float _maxSpeed = 100f;

        public Car()
        {
            /*
             * Bu bir constructor dir.
             * Sinifin olusturuldugu ilk anda otomatik olarak tetiklenen bir method tur.
             * Genis bir baslikta anlatilmasi gerekir,sadece bilgi olmasi adina ekliyorum.
             * Ulasabileceginiz kaynak: (https://bidb.itu.edu.tr/seyir-defteri/blog/2013/09/06/constructors-(yapıcı-metodlar))
             */
            Debug.Log($"I m car,my model is: {_modelName}, max speed: {_maxSpeed}");
        }
    }
}
