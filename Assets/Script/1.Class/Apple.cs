using UnityEngine;

namespace Script._1.Class
{
    /// <summary>
    /// Bir sınıf MonoBehaviour sinifindan turetmiyorsa,
    /// Unity bu sinifi serilestirmek için [System.Serializable]  ihtiyac duyar.
    /// Eger bu oznitelik eklenmezse, Unity bu sinifin icerisindeki verileri serilestiremeyecek ve muhtemelen hata verecektir.
    /// </summary>
    [System.Serializable]


/*
 *Tanim: Siniflar, nesnelerin yapisini tanimlayan planlardir. Unity'de her C# script'i aslinda bir siniftir.
   Kullanim: Unity'de oyun ici varliklar (karakterler, dusmanlar, objeler) icin siniflar kullanilir.
 */
    public class Apple
    {
        private readonly int AppleCount = 10;

        public void GetCurrentAppleCount() => Debug.Log($"Current apple count is:{AppleCount}");
    }
}
