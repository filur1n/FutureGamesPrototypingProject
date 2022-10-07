using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody myRB;
    public float moveSpeed;

    public PlayerMovementController thePlayer;

    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerMovementController>();
    }

    void FixedUpdate()
    {
        myRB.velocity = (transform.forward * moveSpeed);
    }

    void Update()
    {
        transform.LookAt(thePlayer.transform.position);
    }
}
