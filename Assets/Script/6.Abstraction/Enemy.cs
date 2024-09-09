using UnityEngine;

namespace Script._6.Abstraction
{
    public class Enemy : Character
    {
        //Abstract olan atasinda bulunan movespeed degiskenini kendi uzerinde degistirmemizi sagladik.
        public override int MoveSpeed { get; set; }
    
        //Abstract olarak isaretlenen methodu "override" anahtar kelimesi ile tanimliyoruz.
        public override void Move()
        {
            MoveSpeed = 5;
            Debug.Log($"Enemy can move , move speed is : {MoveSpeed}");
        }
    }
}
