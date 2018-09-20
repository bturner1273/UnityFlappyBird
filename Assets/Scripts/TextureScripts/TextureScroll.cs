using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroll : MonoBehaviour {
    [SerializeField] private float scrollSpeed;
    private Renderer rend;
    private float position;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.isGameActive())
        {
            position += scrollSpeed * Time.deltaTime;
            position %= 1.0f;
            rend.material.mainTextureOffset = Vector2.right * position;
        }
	}
}
