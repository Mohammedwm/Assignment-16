using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Character : MonoBehaviour
    {
        public string name;
        private int health;
        protected Position position;
        // Start is called before the first frame update
        public Character(string name,int health,Position position)
        {
            this.name = name;
            this.health = health;
            this.position = position;
        }
        public Character() : this("No name", 100, new Position(0,0,0))
        {
        }
        public int Health
        {
            get { return health;}
            set { 
                if(value > 100) health = 100;
                else if (value < 0) health = 0;
                else health = value;
            }
        }
        public virtual void DisplayInfo()
        {
            Debug.Log("Name : "+name);
            Debug.Log("Health : "+health);
            position.printPosition();
        }
        public void Attack(int damage, Character target)
        {
            AttackDamage(damage,target);
        }
        public void Attack(int damage, Character target,string attackType )
        {
            AttackDamage(damage,target);
            Debug.Log("Attack Type : "+attackType);
        }
        public void AttackDamage(int damage, Character target)
        {
            target.Health -= damage;
        }
    }
}