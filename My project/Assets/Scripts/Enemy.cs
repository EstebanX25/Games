using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float detectionRadius = 10f;
    public float attackRange = 2f;
    public float moveSpeed = 3f;
    public float wanderRadius = 5f;

    private NavMeshAgent agent;
    private bool playerDetected;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerDetected = false;
    }

    private void Update()
    {
        // Verificar si el jugador está dentro del radio de detección.
        playerDetected = Vector3.Distance(transform.position, player.position) <= detectionRadius;

        if (playerDetected)
        {
            // Moverse hacia el jugador si está dentro del radio de ataque.
            if (Vector3.Distance(transform.position, player.position) > attackRange)
            {
                agent.SetDestination(player.position);
            }
            else
            {
                // Atacar al jugador (aquí puedes implementar tu lógica de ataque).
                Debug.Log("Atacar al jugador!");
            }
        }
        else
        {
            // Moverse aleatoriamente si el jugador no está dentro del radio de detección.
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                Vector3 randomDirection = Random.insideUnitSphere * wanderRadius;
                randomDirection += transform.position;
                NavMeshHit hit;
                NavMesh.SamplePosition(randomDirection, out hit, wanderRadius, 1);
                Vector3 finalPosition = hit.position;
                agent.SetDestination(finalPosition);
            }
        }
    }
}

