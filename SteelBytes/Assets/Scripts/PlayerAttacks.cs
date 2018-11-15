using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour {

    public int heat;
    Rigidbody2D player;

	// Use this for initialization
	void Start () {
        heat = 0;
        player = GetComponent<Rigidbody2D>();
	}

    private void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update () {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);

        if (Input.GetMouseButtonDown(1))
        {
            heat += 10;
            Debug.Log("Heat is " + heat);
            if (hit.collider != null)
            {
                Debug.Log("I hit" + hit.collider.tag);
            }
        } else if (Input.GetKeyDown(KeyCode.E))
        {
            if (heat > 50)
                heat -= 50;
            else
                heat = 0;
        }        

	}
}
