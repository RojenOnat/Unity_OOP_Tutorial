using UnityEngine;

namespace Script._3.Encapsulation
{
    [System.Serializable]
    public class Gold
    {
        private int _currentGoldAmount;
        


        /// Tanim: Kapsulleme, bir sinifin verilerini ve islevlerini koruma altina alma yontemidir. Ozellikler ve methodlar, yalnizca ihtiyac duyuldugunda dis dünyaya acilir.
        // Kullanim: Unity'de, bir varligin sadece belirli fonksiyonlarla etkilesimde bulunmasini saglar, böylece oyun mantigi daha güvenli ve düzenli olur.
        public void SetCurrentGoldAmount(int newGoldAmount)
        {
            _currentGoldAmount = newGoldAmount;
            Debug.Log($"_currentGoldAmount field is encapsulated.New gold amount is : {_currentGoldAmount}" );
        }
    }
}
