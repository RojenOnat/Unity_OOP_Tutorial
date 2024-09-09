namespace Script._4.Inheritance
{
   public class Weapon
   {
      internal int _damage;
      internal string _weaponName;
      internal float _attackSpeed;

      public Weapon(int weaponDamage, string weaponName, float attackSpeed)
      {
         _damage = weaponDamage;
         _weaponName = weaponName;
         _attackSpeed = attackSpeed;
      }
   }
}
