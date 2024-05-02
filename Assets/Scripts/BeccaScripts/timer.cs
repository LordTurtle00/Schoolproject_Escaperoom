using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float timeLeft = 600.0f;
    public TMP_Text timerText;
    public TMP_Text loseText;
    // Start is called before the first frame update
    void Start()
    {
        loseText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        timerText.text = timeLeft.ToString();

        if (timeLeft <= 0.0f) 
        {
            loseText.text = "Game over";
            timerText.text = "0";
            Time.timeScale = 0;
        }

        
        

    }
}
