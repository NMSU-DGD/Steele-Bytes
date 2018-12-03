using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int health;

	// Use this for initialization
	void Start () {
        health = 20;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Laser")
        {
            health -= 10;
            Debug.Log("Laser hits enemy, health = " + health);
        }
        if (health <= 0)
        {
            Debug.Log("enemy is dead");
            DestroyImmediate(gameObject);

        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
