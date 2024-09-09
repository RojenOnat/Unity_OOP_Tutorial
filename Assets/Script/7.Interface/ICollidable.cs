

/*
 * Tanim: Interface'ler, bir sinifin uygulamasi gereken methodlarin bir sozlesmesini tanimlar. Kalitim gibi calisir, ancak siniflar birden fazla interface'i uygulayabilir.
   Kullanim: Unity'de farkli varliklarin ayni islevselligi farkli sekillerde uygulamalarini saglayabilir.
 */
namespace Script._7.Interface
{
    public interface ICollidable
    {
        public void WhenCollide();
    }
}
