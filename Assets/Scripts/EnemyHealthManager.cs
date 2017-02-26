using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int health;
    private int currentHealth;

    public int score = 0;

	// Use this for initialization
	void Start () {
        currentHealth = health;
	}
	
	// Update is called once per frame
	void Update () {

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            score++;
        }
	}

    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;
    }
}
