using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject square;
    public GameObject gameOverText;

    public static gameManager I;

    void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeSquare", 0.0f, 0.5f);

    }

    void makeSquare()
    {
        Instantiate(square);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver()
    {
        gameOverText.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
