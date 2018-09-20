using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour {
    [SerializeField] private KeyCode flapKey;
    private PlayerController playerController;
    private bool flapKeyPressed;

	// Use this for initialization
	void Start () {
        playerController = GetComponent<PlayerController>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!flapKeyPressed)
        {
            flapKeyPressed = Input.GetKeyDown(flapKey);
        }  
	}

    private void FixedUpdate()
    {
        playerController.ProcessInput(flapKeyPressed);
        ResetFlags();
    }

    public void ResetFlags()
    {
        flapKeyPressed = false;
    }
}
