using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float deathTime = 3f; //Seconds

    private void Awake() {
        StartCoroutine(Die());
    }

    IEnumerator Die() {
        yield return new WaitForSeconds(deathTime);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Enemy") {
            Destroy(gameObject);
        }
    }
}
