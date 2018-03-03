using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject sp01;
    public GameObject sp02;

    public GameObject enemyPrefab;

    public static GameManager instance;

    private void Awake() {
        if (instance == null)
            instance = this;
    }

    public void SpawnEnemyAtSpawnPositions() {
        SpawnEnemy(sp01.transform.position);
        SpawnEnemy(sp02.transform.position);
    }

    public void SpawnEnemy(Vector3 position) {
        Instantiate(enemyPrefab, position, Quaternion.identity);
    }
}
