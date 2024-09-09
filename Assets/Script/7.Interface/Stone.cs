using UnityEngine;

namespace Script._7.Interface
{
    public class Stone : ICollidable
    {
        public void WhenCollide()
        {
            Debug.Log("Collide with stone!");
        }
    }
}
