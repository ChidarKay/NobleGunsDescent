using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour {

    public GameObject bullet;
    public GameObject barrelFront;

    string fireKey = "Fire1";
	
	void Start() {
    }
	void FixedUpdate () {
		if (Input.GetButton(fireKey)) {
            GameObject bulletInstance = Instantiate(bullet, barrelFront.transform.position, Quaternion.identity) as GameObject;
            bulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * 50000);
        }
    }
}
