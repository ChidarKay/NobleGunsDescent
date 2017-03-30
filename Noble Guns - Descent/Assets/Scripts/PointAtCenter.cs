using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAtCenter : MonoBehaviour {

    GameObject firstPersonCharacter;
    Camera cameraMain;
    public float z;

    void Start() {
        firstPersonCharacter = GameObject.Find("FirstPersonCharacter");
        cameraMain = firstPersonCharacter.GetComponent<Camera>();
    }

	void Update () {
        transform.forward = cameraMain.ScreenToWorldPoint(new Vector3((Screen.width / 2), (Screen.height / 2), z));
	}
}
