using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private Button startButton;
    public bool isGameActive;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        startButton = GetComponent<Button>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
