using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour {

    public float movementSpeed = 10f;

    private void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Debug.Log("Horizontal values: " + horizontal);
        //Debug.Log("Vertical valıues: " + vertical);

        transform.position += new Vector3(horizontal * Time.deltaTime, vertical * Time.deltaTime) * movementSpeed;
    }
}
