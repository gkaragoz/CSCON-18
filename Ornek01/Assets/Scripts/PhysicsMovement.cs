using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour {

    public float speed;

    private GameObject _whiteCube;
    private Rigidbody _rigidbody;

    private void Awake() {
        _whiteCube = GameObject.Find("White_Cube");
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        _rigidbody.velocity = new Vector3(horizontal, 0f, vertical) * speed;
    }

    private void HideTheCube(GameObject obj) {
        obj.SetActive(false);
    }

    private void ShowTheCube(GameObject obj) {
        obj.SetActive(true);
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("I came to sensor's range.");
        HideTheCube(_whiteCube);
    }

    private void OnTriggerStay(Collider other) {
        Debug.Log("I'm in the sensor's range.");
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("I'm out of the sensor.");
        ShowTheCube(_whiteCube);
    }

}
