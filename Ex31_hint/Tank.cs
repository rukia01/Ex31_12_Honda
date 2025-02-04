﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Tank : Character
    {
        public int bullet = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="hp">体力</param>
        /// <param name="power">攻撃力</param>
        /// <param name="poisonResistance">毒物耐性</param>
        public Tank(string name, float hp, float power, bool poisonResistance = true) : base(name, hp, power, poisonResistance) { }
        public override void Attack(Character destination)
        {
            if (bullet > 0)
            {
                bullet--;
                Console.WriteLine($"{this.name}は{destination.name}に向け大砲を発射！");
                Console.WriteLine($"{destination.name}はうしろに吹っ飛んだ！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{base.name}は弾切れです！");
            }
        }
    }
}