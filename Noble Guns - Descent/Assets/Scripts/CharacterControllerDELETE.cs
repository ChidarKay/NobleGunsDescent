using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerDELETE : MonoBehaviour {
    public float movementSpeed;

    void Update () {
        if (Input.GetKey("w")) {
            transform.position += Vector3.left * movementSpeed;
        }
        if (Input.GetKey("s")) {
            transform.position += Vector3.right * movementSpeed;
        }
        if (Input.GetKey("d")) {
            transform.position += Vector3.forward * movementSpeed;
        }
        if (Input.GetKey("a")) {
            transform.position += Vector3.back * movementSpeed;
        }

        //if (Input.GetAxis("Mouse X") > 0) {
        //    transform.eulerAngles += new Vector3(0, 0.5f, 0);
        //}
        //if (Input.GetAxis("Mouse X") < 0) {
        //    transform.eulerAngles += new Vector3(0, -0.5f, 0);
        //}
        //if (Input.GetAxis("Mouse Y") > 0) {
        //    transform.eulerAngles += new Vector3(-0.5f, 0, 0);
        //}
        //if (Input.GetAxis("Mouse Y") < 0) {
        //    transform.eulerAngles += new Vector3(0.5f, 0, 0);
        //}

        transform.LookAt(Input.mousePosition);
    }
}
