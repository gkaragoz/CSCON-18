using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float speed;
    public GameObject target;

    private Rigidbody _rigidbody;

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate() {
        if (target != null)
            MoveToTarget();
    }

    private void MoveToTarget() {
        Vector3 direction = target.transform.position - transform.position;
        _rigidbody.velocity = direction.normalized * speed;
    }

}
