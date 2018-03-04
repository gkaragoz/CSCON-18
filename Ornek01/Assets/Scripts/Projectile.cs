using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public List<GameObject> allEnemies = new List<GameObject>();

    public float deathTime = 3f; //Seconds

    private void Awake() {
        StartCoroutine(Die());
        allEnemies = GameObject.FindGameObjectsWithTag("Enemy").ToList();
    }

    private void Update() {
        foreach (GameObject enemy in allEnemies) {
            if (IsProjectileIntersectedWith(enemy.transform)) {
                Destroy(gameObject);
            }
        }
    }

    IEnumerator Die() {
        yield return new WaitForSeconds(deathTime);
        Destroy(gameObject);
    }

    public bool IsProjectileIntersectedWith(Transform obj) {
        float distance = Vector3.Distance(transform.position, obj.position);

        if (distance <= 1f) {
            return true;
        }
        return false;
    }
}
