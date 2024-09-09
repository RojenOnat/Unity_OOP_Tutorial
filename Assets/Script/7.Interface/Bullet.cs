using UnityEngine;

namespace Script._7.Interface
{
    public class Bullet: ICollidable
    {
        public void WhenCollide()
        {
            Debug.Log("Collide with bullet!");
        }
    }
}
