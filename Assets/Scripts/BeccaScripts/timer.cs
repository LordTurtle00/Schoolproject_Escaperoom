using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float timeLeft = 600.0f;
    public float textTimer = 5.0f;
    float currentTextTimer = 0;

    public TMP_Text timerText;
    public TMP_Text loseText;
    public TMP_Text warningText;
    public Button restartButton;
    public Button exitButton;
    [SerializeField] public GameObject cam;

    public GameObject warningTextObj;
    public GameObject exitButtonObj;
    public GameObject restartButtonObj;
    public GameObject player;

    bool currentTimerTextSet = false;
    bool warningFiveMin = false;
    bool warningOneMin = false;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 5.0f;
        textTimer = 5.0f;
        currentTextTimer = 0;
        loseText.text = "";
        warningTextObj.SetActive(false);
        exitButtonObj.SetActive(false);
        restartButtonObj.SetActive(false);
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        timerText.text = Mathf.Round(timeLeft).ToString();

        print("hejhejehjehje");

        if (timeLeft <= 300.0f && timeLeft > 295.0f && !warningFiveMin)
        {
            if(!currentTimerTextSet)
            {
                currentTextTimer = textTimer;
                currentTimerTextSet = true;
                warningTextObj.SetActive(true);
            }

            currentTextTimer -= Time.deltaTime;

            if(currentTextTimer <= 0.1f)
            {
                warningText.text = "1 minute left"; 
                currentTimerTextSet = false;
                warningTextObj.SetActive(false);
                warningFiveMin = true;
            }
        }

        if (timeLeft <= 60.0f &&  timeLeft > 55.0f && !warningOneMin)
        {
            if (!currentTimerTextSet)
            {
                currentTextTimer = textTimer;
                currentTimerTextSet = true;
                warningTextObj.SetActive(true);
            }

            currentTextTimer -= Time.deltaTime;

            if(currentTextTimer <= 0.1f)
            {
                currentTimerTextSet = false;
                warningTextObj.SetActive(false);
                warningOneMin = true;
            }
        }

        if (timeLeft <= 0.0f) 
        {
            loseText.text = "Game over";
            exitButtonObj.SetActive(true);
            restartButtonObj.SetActive(true);
            timerText.text = "0";
            player.GetComponent<PlayerMovement>().Speed = 0;
            cam.GetComponent<CameraController>().Sensitivity = 0;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }

        
        

    }
    public void exitGame()
    {
        Application.Quit();
        Debug.Log("exit");
    }
    
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("restart");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
