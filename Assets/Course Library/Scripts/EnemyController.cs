using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f;

    private Rigidbody enemyRB;
    private GameObject player;

    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        
    }

    void Update()
    {
        Vector3 lookDirection = player.transform.position - transform.position;
        enemyRB.AddForce(lookDirection.normalized * speed);
        
        if (transform.position.y < -10)
        {
            Destroy(gameObject);

        }
    }

}
