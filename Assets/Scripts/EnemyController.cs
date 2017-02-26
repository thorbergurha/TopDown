using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private Rigidbody myRB;
    public float moveSpeed;

    public PlayerController thePlayer;

	// Use this for initialization
	void Start () {
        myRB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(thePlayer.transform.position);
	}

    void FixedUpdate()
    {
        myRB.velocity = (transform.forward * moveSpeed);
    }
}
