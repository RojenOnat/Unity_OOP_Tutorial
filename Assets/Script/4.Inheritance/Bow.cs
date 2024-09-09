using UnityEngine;

namespace Script._4.Inheritance
{
    public class Bow : Weapon
    {
        public Bow(int weaponDamage, string weaponName, float attackSpeed) : base(weaponDamage, weaponName, attackSpeed)
        {
            Debug.Log($"Weapon name is: {weaponName} , Current weapon damage is : {weaponDamage} , Current attack speed is : {attackSpeed}");
        }
        
    }
}
