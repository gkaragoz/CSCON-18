using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemyGenerator : MonoBehaviour {

    public int count = 100;

    public Transform prefab;

    private void Awake() {
        StartCoroutine(SpawnEnemySecond());
    }

    IEnumerator SpawnEnemySecond() {
        for (int ii = 0; ii < count; ii++) {
            Vector3 position = new Vector3(Random.Range(-30f, 70f), Random.Range(18f, -40f), 0f);
            yield return new WaitForSeconds(0.2f);
            SpawnEnemy(position);
        }
    }

    public void SpawnEnemy(Vector3 position) {
        Instantiate(prefab, position, Quaternion.identity);
    }

}
