using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    public GameObject enemy;

    //Definindo posição mínima e máxima onde o inimigo será criado
    public float xMin = -2.5f;
    public float xMax = 2.5f;
    public float yMin = 6f;
    public float yMax = 9f;

    //Tempo de spawn
    public float spawnTime = 3f;

    void Start() {
        
    }

    void Update() {
        
        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0) {
            Vector3 position = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax));

            Instantiate(enemy, position, Quaternion.identity);

            spawnTime = 3f;
        }

    }

}
