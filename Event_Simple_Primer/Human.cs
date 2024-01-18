using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Event_Simple_Primer
{
    public delegate void ChangeHealth(int Health);
    internal class Human
    {
        private int _health;
        private int _maxHealth;

        public Human(int health)
        {
            //fff
            _health = health;
            _maxHealth = Health;
        }

        public int Health
        {
            get { return _health; }
            set
            {
                if(value < 0)
                {
                    _health = 0;
                }
                else if(value > _maxHealth)
                {
                    _health = _maxHealth;
                }
                else
                {
                    _health = value;
                }
                OnChangeHealth.Invoke(value < 0? 0 : value);

            }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
        }

        public event ChangeHealth OnChangeHealth;
    }
}
