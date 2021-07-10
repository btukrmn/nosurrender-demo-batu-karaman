using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    
    void Start()
    {

    }

    void Update()
    {
        //Navigating enemy to player with NavMesh
        enemy.SetDestination(player.position);
    }



}
