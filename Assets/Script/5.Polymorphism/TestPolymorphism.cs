using System;
using UnityEngine;

namespace Script._5.Polymorphism
{
    public class TestPolymorphism : MonoBehaviour
    {
        private Bird _bird;
        private Dog _dog;

        private void Start()
        {
            //Yukarida olusturdugumuz nesneleri assagida isaretliyoruz.(Isaretlemeden kasit ne olduklarini belirtiyoruz sisteme.)
            _bird = new Bird();
            _dog = new Dog();
            
            
            _bird.Attack();
            _dog.Attack();
        }
    }
}
