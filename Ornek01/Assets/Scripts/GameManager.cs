using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public List<GameObject> allSpawnPoints = new List<GameObject>();
    public GameObject enemyPrefab;

    public static GameManager instance;

    private void Awake() {
        if (instance == null)
            instance = this;
    }

    public void SpawnEnemyAtSpawnPositions() {
        foreach (GameObject spawnPoint in allSpawnPoints) {
            SpawnEnemy(spawnPoint.transform.position);
        }
    }

    public void SpawnEnemy(Vector3 position) {
        Instantiate(enemyPrefab, position, Quaternion.identity);
    }
}
