using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhysicsMovement : MonoBehaviour {

    public float speed;

    private Rigidbody _rigidbody;

    private void Awake() {
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

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Enemy") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
