using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Cow:Character
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="hp">体力</param>
        /// <param name="power">攻撃力</param>
        /// <param name="poisonResistance">毒物耐性</param>
        public Cow(string name, float hp, float power, bool poisonResistance = false) : base(name, hp, power, poisonResistance) { }
        public override void Attack(Character destination)
        {
            if (this.hp > 5)
            {
                Console.WriteLine($"{destination.name}は{this.name}の角で突かれた!");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{this.name}は体力が少なくなり、動けなくなった");
            }
        }
    }
}
