using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameManager gameManager;
    public float horizontalInput;
    public float speed = 10.0f;
    public float bounds = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Player movement
        if (gameManager.isGameActive == true)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);
            
        }

        //Player Bounds
        if (transform.position.x < -bounds)
        {
            transform.position = new Vector3(-bounds, transform.position.y, transform.position.z);
        }

        if (transform.position.x > bounds)
        {
            transform.position = new Vector3(bounds, transform.position.y, transform.position.z);
        }
    }

    //Player Collision
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            gameManager.victoryScreen.gameObject.SetActive(true);
            gameManager.safeSplash.gameObject.SetActive(true);
        }
        else if (other.gameObject.CompareTag("Ice"))
        {
            Destroy(gameObject);
            gameManager.failureScreen.gameObject.SetActive(true);
            gameManager.agroundSplash.gameObject.SetActive(true);
        }

        gameManager.restartButton.gameObject.SetActive(true);
        gameManager.isGameActive = false;
    }
}