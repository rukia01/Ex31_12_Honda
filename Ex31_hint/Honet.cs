using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Honet:Character
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="hp">体力</param>
        /// <param name="power">攻撃力</param>
        /// <param name="poisonResistance">毒物耐性</param>
        public Honet(string name, float hp, float power, bool poisonResistance = false) : base(name, hp, power, poisonResistance) { }
        public override void Attack(Character destination)
        {
            if (destination.poisonResistance)
            {
                Console.WriteLine($"{this.name}は{destination.name}を毒針で攻撃した。");
                Console.WriteLine($"しかし、{destination.name}は毒が効かなかった。");
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{this.name}は{destination.name}を毒針で攻撃した。");
                Console.WriteLine($"{destination.name}は毒で即死した。");
                destination.hp = 0;
            }
        }
    }
}
