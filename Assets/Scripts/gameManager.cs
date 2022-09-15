using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject square;
    public GameObject gameOverText;

    public Text timeText;
    float alive = 0.0f;

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
        alive += Time.deltaTime;
        timeText.text = alive.ToString("N2");
            
    }

    public void gameOver()
    {
        gameOverText.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
