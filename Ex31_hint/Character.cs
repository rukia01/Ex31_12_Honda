﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Character
    {
        readonly public string name;
        public float hp;
        protected float power;
        public bool poisonResistance;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="hp">体力</param>
        /// <param name="power">攻撃力</param>
        /// <param name="poisonResistance">毒物耐性</param>
        public Character(string name,float hp,float power,bool poisonResistance = false)
        {
            this.name = name;
            this.hp = hp;
            this.power = power;
            this.poisonResistance = poisonResistance;
        }
        public virtual void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}をぶんなぐった！");
            Console.WriteLine($"{destination.name}は{this.power}のダメージ");
            destination.hp -= this.power;
            Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}
