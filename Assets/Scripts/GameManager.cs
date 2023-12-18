using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject titleScreen;
    public List<GameObject> tiles;
    public GameObject tile;
    public TextMeshProUGUI victoryScreen;
    public TextMeshProUGUI failureScreen;
    public Image safeSplash;
    public Image agroundSplash;
    public Button restartButton;
    public bool isGameActive = false;
    private float tileWidth;

    // Start is called before the first frame update
    void Start()
    {
        tileWidth = tile.GetComponent<MeshRenderer>().bounds.size.z;
        Shuffle(tiles);
        PlaceTiles(tiles);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        isGameActive = !isGameActive;
        Debug.Log("Boolean value is now: " + isGameActive);
        titleScreen.gameObject.SetActive(false);
    }

    void Shuffle(List<GameObject> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            GameObject temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }

    void PlaceTiles(List<GameObject> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            // Arrange objects in a horizontal line
            list[i].transform.position = new Vector3(0, 0, (i + 1) * tileWidth);
            Instantiate(list[i], transform);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
