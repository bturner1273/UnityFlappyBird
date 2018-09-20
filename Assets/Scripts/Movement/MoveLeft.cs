using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {
    [SerializeField] private float moveSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.isGameActive())
        {
            transform.Translate(Vector3.left*moveSpeed*Time.deltaTime);
        }
	}
}
