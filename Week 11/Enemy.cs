using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private bool spawnLeft = false;
    private bool spawnRight = false;

    // Start is called before the first frame update
    void Start()
    {
        /* First, the spawn position must be determined since the movement pattern will change
        depending on if the enemy spawned in the top left or top right. */
        if (transform.position.x == -9f)
        {
            spawnLeft = true;
        }
        else if (transform.position.x == 9f)
        {
            spawnRight = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnLeft == true)
        {
            // If the enemy spawned in the top left, it will move down and to the right consistently.
            transform.Translate(new Vector3(1f, -1f, 0f) * Time.deltaTime * 1.5f);
        }
        else if (spawnRight == true)
        {
            // If the enemy spawned in the top right, it will move down and to the left consistently.
            transform.Translate(new Vector3(-1f, -1f, 0f) * Time.deltaTime * 1.5f);
        }
        else
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3f);
        }

        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
