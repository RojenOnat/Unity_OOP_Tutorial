using UnityEngine;

namespace Script._6.Abstraction
{
    public class Player : Character
    {
        public override int MoveSpeed { get; set; }
    
        public override void Move()
        {
            MoveSpeed = 1;
        
            Debug.Log($"Player can move , move speed is : {MoveSpeed}");
        }
    }
}
