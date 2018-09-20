using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D rb;
    [SerializeField] private float flapForce;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ProcessInput(bool flapKey)
    {
        if (GameManager.isGameActive())
        {
            if (flapKey)
            {
                rb.velocity = Vector2.up * flapForce;
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (GameManager.isGameActive())
        {
            if (col.gameObject.CompareTag("pipe") || col.gameObject.CompareTag("ground"))
            {
                GameManager.setGameActive(false);
                
            }else if (col.gameObject.CompareTag("scoreBox"))
            {
                GameManager.IncrementScore();
            }
        }
    }
}
