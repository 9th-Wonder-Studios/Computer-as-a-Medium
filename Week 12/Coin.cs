using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Saves a reference to the GameManager since we will need to call its AddScore() method later.
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        // Finds the GameManager and gets its GameManager script.
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
        // Destroys the coin after 4 seconds of it being on the screen.
        Destroy(this.gameObject, 4);
    }
    
    private void OnTriggerEnter2D(Collider2D objectHit)
    {
        // If the player collides with the coin, it will be destroyed and add 1 to the score using GameManager.AddScore().
        if(objectHit.tag == "Player")
        {
            gameManager.AddScore(1);
            Destroy(this.gameObject);
        }
    }
}