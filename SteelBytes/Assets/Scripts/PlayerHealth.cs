using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public Slider healthbar;
    public int health;

	// Use this for initialization
	void Start () {
        health = 100;
	}

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "FlameBall" || collision.gameObject.tag == "MageBullet") {
            health = health - 10;
            Debug.Log("FlameBall hits " + this.tag + ", health = " + health);
            Debug.Log("Child: " + this.tag);
        }
        if (health <= 0) {
            Debug.Log("Player is dead");
            SceneManager.LoadScene("Assimilate1Scene");
        }
    }

    // Update is called once per frame
    void Update () {
        healthbar.value = health;
	}
}
