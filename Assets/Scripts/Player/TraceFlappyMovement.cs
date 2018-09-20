using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceFlappyMovement : MonoBehaviour {
    [SerializeField] private GameObject flappy;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = flappy.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update () {
        transform.position = flappy.transform.position + new Vector3(20,10,0) + (Vector3)rb.velocity;
	}
}
