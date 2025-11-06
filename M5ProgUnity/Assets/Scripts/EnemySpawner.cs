using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;
    private List<GameObject> enemies = new List<GameObject>();
    private float timeElapsed;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                GameObject enemyClone= Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
                enemies.Add(enemyClone);
            }
        }
        else if (timeElapsed >= 1)
        {
            timeElapsed = 0;
            for (int i = 0; i < 3; i++)
            {
                GameObject enemyClone = Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
                enemies.Add(enemyClone);
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach(GameObject enemyClone in enemies)
            {
                Destroy(enemyClone);
            }
            enemies.Clear();
        }
    }
}
