using System;
using UnityEngine;

namespace Script._7.Interface
{
   public class TestInterface : MonoBehaviour
   {
      private void Start()
      {
         Bullet bullet = new Bullet();
         Stone stone = new Stone();
         
         bullet.WhenCollide();
         stone.WhenCollide();
      }
   }
}
