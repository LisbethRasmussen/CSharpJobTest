﻿using UnityEngine;

namespace com.brainplus.jobtest.serialization.scenario1
{
    public class Health : MonoBehaviour
    {
        //Changed--------------
        [SerializeField]
        private int maxHealth = 100; // TODO: Make readonly for other classes, while still serialized (tweakable in the inspector)
        public int getMaxHealth() { //There should be a smarter way for this, but I don't know it yet
            return maxHealth;
        }
        public int currentHealth { get; private set; } = 0; // TODO: Make readonly for other classes
        //Changed--------------

        /// <summary>
        /// You are not allowed to change this function.
        /// </summary>
        void Awake()
        {
            // Start with max health
            currentHealth = maxHealth;
        }

        /// <summary>
        /// You are not allowed to change this function.
        /// </summary>
        public void TakeDamage(int damage)
        {
            // Subtract damage from health, ensuring we cant go below 0
            currentHealth = Mathf.Max(0, currentHealth - damage);
        }

        /// <summary>
        /// You are not allowed to change this function.
        /// </summary>
        public bool IsDead
        {
            get
            {
                return currentHealth <= 0;
            }
        }
    }
}
