using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SayacScript : MonoBehaviour
{
    [SerializeField] Text text;


    float timeRemaining = 5;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Kalan Süre: "+timeRemaining;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining >0)
        {
            timeRemaining -= Time.deltaTime;
            text.text = "Kalan Süre: " + timeRemaining;
        }
        else
        {
            text.text = "Oyun bitti";
            pauseGame();
        }
    }

    void pauseGame()
    {
        Time.timeScale = 0;
    }
}
