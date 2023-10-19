using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace player_s_guns
{
    interface IHasInfo
    {
        void ShowInfo();
    }

    interface IWeapon
    {
        void Fire();
    }

    interface IThrowingWeapon : IWeapon //TODO
    {
        void Throw();
    }

    abstract class Weapon : IHasInfo, IWeapon
    {
        public abstract int Damage { get;  }
        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage: {Damage}");
        }
    }

    class Gun : Weapon
    {
        public override  int Damage => 8;

        public override void Fire()
        {
            Console.WriteLine("Shot!");
        }
    }

    class LaserGun : Weapon
    {
        public override int Damage => 5;

        public override void Fire()
        {
            Console.WriteLine("Piu!");
        }
    }

    class Bow : Weapon
    {
        public override int Damage => 3;

        public override void Fire()
        {
            Console.WriteLine("Chponk!");
        }
    }

    class Knife : Weapon //TODO
    {
        public override int Damage => 3;

        public override void Fire()
        {
            Console.WriteLine("Zzuh!");
        }

        public  void Throw()
        {
            Console.WriteLine("Shiiu!");
        }
    }

    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void Throw(Knife throwingWeapon) //TODO
        {
            throwingWeapon.Throw();
        }

        public void CheckInfo(IHasInfo hasInfo)
        {
            hasInfo.ShowInfo();
        }
    }

    class Box : IHasInfo
    {
        public void ShowInfo()
        {
            Console.WriteLine("I'm a Box!!!");
        }
    }

    class Program
    {
        static void Main()
        {
            Player player = new Player();
            Weapon[] inventory = { new Gun(), new LaserGun(), new Bow(), new Knife() };

            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }

            player.Throw(new Knife());
            
            player.CheckInfo(new Box());
        }
    }
}