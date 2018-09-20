using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float yRange;
    [SerializeField] private float spawnDelay;

    private float spawnTimer;

	// Use this for initialization
	void Start () {
        spawnTimer = spawnDelay;
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.isGameActive()) {
            spawnTimer -= Time.deltaTime;
            if (spawnTimer < 0.0f)
            {
                Instantiate(pipePrefab,
                    transform.position + Vector3.up * Random.Range(-yRange, yRange),
                    Quaternion.identity);
                spawnTimer = spawnDelay;
            }
        }
	}
}
