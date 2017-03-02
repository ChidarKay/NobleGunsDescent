using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public float timeToDestruct;

    float time;

	void Update () {
        time += Time.deltaTime;

        if (time > timeToDestruct) {
            Destroy(gameObject);
        }
	}
}
