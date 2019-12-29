using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterCtrl : MonoBehaviour
{
    private NavMeshAgent nv;
    private Transform playerTr;

    void Start()
    {
        nv = GetComponent<NavMeshAgent>(); 
        playerTr = GameObject.Find("Player").GetComponent<Transform>();
        //playerTr = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        nv.SetDestination(playerTr.position);
    }
}
