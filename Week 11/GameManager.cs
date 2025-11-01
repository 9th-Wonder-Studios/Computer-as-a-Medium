using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemyOnePrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyOne", 1, 2);
        InvokeRepeating("CreateEnemyTwo", 2, 4);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }

    void CreateEnemyTwo()
    {
        // Range is between 0 and 2 since 2 is exclusive.
        int startingPos = Random.Range(0, 2);

        // Depending on the number chosen by startingPos, the enemy will spawn in a different corner of the scene.
        if (startingPos == 0)
        {
            Instantiate(enemyOnePrefab, new Vector3(-9f, 6.5f, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(enemyOnePrefab, new Vector3(9f, 6.5f, 0), Quaternion.identity);
        }
    }
}
