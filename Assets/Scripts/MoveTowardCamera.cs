using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardCamera : MonoBehaviour
{
    private GameManager gameManager;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive == true)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
          
    }
}
