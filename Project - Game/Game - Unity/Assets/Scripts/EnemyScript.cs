using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public Transform targetObj;

    public float movementSpeed = 2f;

    public NavMeshAgent enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, movementSpeed * Time.deltaTime);
        enemy.SetDestination(targetObj.position);
    }
}
