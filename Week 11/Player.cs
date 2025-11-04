using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float playerSpeed;
    private float horizontalInput;
    private float verticalInput;

    private float horizontalScreenLimit = 9.5f;
    private float verticalScreenLimit = 5f;

    public GameObject bulletPrefab;

    //Asher Moffitt Was Here :)
    void Start()
    {
        playerSpeed = 6f;
        //This function is called at the start of the game

    }

    void Update()
    {
        //This function is called every frame; 60 frames/second
        Movement();
        Shooting();

    }

    void Shooting()
    {
        //if the player presses the SPACE key, create a projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }

    void Movement()
    {
        // Horizontal movement
        float inputX = Input.GetAxisRaw("Horizontal");
        Vector2 position = transform.position;
        position.x += inputX * playerSpeed * Time.deltaTime;

        // Wrap-Around
        if (position.x < -horizontalScreenLimit)
        {
            position.x = horizontalScreenLimit;
        }
        else if (position.x > horizontalScreenLimit)
        {
            position.x = -horizontalScreenLimit;
        }

        // Vertical movement
        float inputY = Input.GetAxisRaw("Vertical");
        position.y += inputY * playerSpeed * Time.deltaTime;

        // Vertical Clamping
        float bottom = -verticalScreenLimit;
        float top = 0f;
        position.y = Mathf.Clamp(position.y, bottom, top);

        transform.position = position;
    }

}
