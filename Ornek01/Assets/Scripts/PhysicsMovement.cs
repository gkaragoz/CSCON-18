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

    private void OnTriggerEnter(Collider other) {
        GameManager.instance.SpawnEnemyAtSpawnPositions();
        other.gameObject.SetActive(false);
    }

}
