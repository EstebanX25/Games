using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    // Start is called before the first frame update
    public class CombatController : MonoBehaviour
    {
        public int playerDamage = 10;
        public int enemyDamage = 5;

        // Este método se llamará desde el personaje jugador cuando ataque.
        public void PlayerAttack(GameObject target)
        {
            HealthController healthController = target.GetComponent<HealthController>();
            if (healthController != null)
            {
                healthController.TakeDamage(playerDamage);
            }
        }

        // Este método se llamará desde el enemigo cuando ataque.
        public void EnemyAttack(GameObject target)
        {
            HealthController healthController = target.GetComponent<HealthController>();
            if (healthController != null)
            {
                healthController.TakeDamage(enemyDamage);
            }
        }
    }
}
