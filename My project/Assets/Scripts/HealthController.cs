using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class HealthController : MonoBehaviour
    {
        public int maxHealth = 100;
        private int currentHealth;

        private void Start()
        {
            currentHealth = maxHealth;
        }

        public void TakeDamage(int damageAmount)
        {
            currentHealth -= damageAmount;
            if (currentHealth <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            // Agrega aquí cualquier lógica que desees cuando el personaje muera.
            Destroy(gameObject);
        }
    }


