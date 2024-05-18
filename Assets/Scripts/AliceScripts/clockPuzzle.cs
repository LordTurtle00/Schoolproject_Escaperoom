using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class clockPuzzle : MonoBehaviour
{
    /*  
    Description of script:
        uses tags in combination with counter to check right button
        button tags: button1, button2 ... button4
    */

    int counter = 1;
    //int numOfButtonsPressed;
    Ray ray;
    float maxDistance = 10f;
    public bool puzzleCompleted = false;
    [SerializeField] GameObject wand;

    //button animation
    //float amountOfDelay = 0.1f;
    public bool player_buttonPressed1 = false;
    public bool player_buttonPressed2 = false;
    public bool player_buttonPressed3 = false;
    public bool player_buttonPressed4 = false;


    private void Start()
    {
        wand = GameObject.FindGameObjectWithTag("wand");
        wand.SetActive(false);

    }

    
    void buttonRay()
    {
        /*if (Physics.Raycast(ray, out RaycastHit hitInfo, maxDistance))
        {
            if (hitInfo.collider.gameObject.CompareTag("button1"))
            {
                StartCoroutine(animationDelay1());
                IEnumerator animationDelay1()
                {
                    player_buttonPressed1 = true;
                    yield return new WaitForSeconds(amountOfDelay);
                    player_buttonPressed1 = false;
                }
            }
            else if (hitInfo.collider.gameObject.CompareTag("button2"))
            {
                StartCoroutine(animationDelay2());
                IEnumerator animationDelay2()
                {
                    player_buttonPressed2 = true;
                    yield return new WaitForSeconds(amountOfDelay);
                    player_buttonPressed2 = false;
                }
            }
            else if (hitInfo.collider.gameObject.CompareTag("button3"))
            {
                StartCoroutine(animationDelay3());
                IEnumerator animationDelay3()
                {
                    player_buttonPressed3 = true;
                    yield return new WaitForSeconds(amountOfDelay);
                    player_buttonPressed3 = false;
                }
            }
            else if (hitInfo.collider.gameObject.CompareTag("button4"))
            {
                StartCoroutine(animationDelay4());
                IEnumerator animationDelay4()
                {
                    player_buttonPressed4 = true;
                    yield return new WaitForSeconds(amountOfDelay);
                    player_buttonPressed4 = false;
                }
            }*/

        if (Physics.Raycast(ray, out RaycastHit hitInfo, maxDistance))
        {
            if (hitInfo.collider.gameObject.CompareTag("button1"))
            {
                player_buttonPressed1 = true;
            }
            else if (hitInfo.collider.gameObject.CompareTag("button2"))
            {
                player_buttonPressed2 = true;
            }
            else if (hitInfo.collider.gameObject.CompareTag("button3"))
            {
                player_buttonPressed3 = true;
            }
            else if (hitInfo.collider.gameObject.CompareTag("button4"))
            {
                player_buttonPressed4 = true;
            }

            if (player_buttonPressed1 &&
                player_buttonPressed2 &&
                player_buttonPressed3 &&
                player_buttonPressed4 &&
                !puzzleCompleted)
            {
                player_buttonPressed1 = false;
                player_buttonPressed2 = false;
                player_buttonPressed3 = false;
                player_buttonPressed4 = false;
            }

            string _tag;
            _tag = "button" + counter.ToString();
            if (hitInfo.collider.gameObject.CompareTag(_tag))
            {
                //right sequence
                counter++;
                if(counter == 5)
                {
                    puzzleCompleted = true;
                }
            }
            else
            {
                // wrong sequence
                counter = 1;
            }
        }

    }


    private void Update()
    {
        if (!puzzleCompleted)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
                buttonRay();
            }
        }

        if(puzzleCompleted)
        {
            player_buttonPressed1 = true;
            player_buttonPressed2 = true;
            player_buttonPressed3 = true;
            player_buttonPressed4 = true;

            wand.SetActive(true);

        }
    }
}
