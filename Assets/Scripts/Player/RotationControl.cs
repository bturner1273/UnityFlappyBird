using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationControl : MonoBehaviour {

    [SerializeField] private GameObject toPointTo;
	
	// Update is called once per frame
	void Update () {
        Vector3 diff = toPointTo.transform.position - transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rot_z);
    }
}
