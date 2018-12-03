using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int health;

	// Use this for initialization
	void Start () {
        health = 100;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "FlameBall")
        {
            health -= 10;
            Debug.Log("FlameBall hits player, health = " + health);
        }
        if (health <= 0)
        {
            Debug.Log("Player is dead");
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
