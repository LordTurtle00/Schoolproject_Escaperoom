using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class clockPuzzle : MonoBehaviour
{
    // Description of script:
    // use counter in combination with tags to check right button
    // button tags: button1, button2 ... button4

    int counter = 1;
    Ray ray;
    float maxDistance = 10f;
    public bool puzzleCompleted = false;
    [SerializeField] GameObject wand;
    public GameObject liquid;

    private void Start()
    {
        wand = GameObject.FindGameObjectWithTag("wand");
        liquid = GameObject.FindGameObjectWithTag("CouldronLiquid");
        wand.SetActive(false);
    }

    void buttonRay()
    {
        if (Physics.Raycast(ray, out RaycastHit hitInfo, maxDistance))
        {
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

    /*void colorChange()
    {
        Get the Renderer component from liquid
        var liquidRenderer = liquid.GetComponent<Renderer>();

        Call SetColor using the shader property name "_Color" and setting the color to red
        
        liquidRenderer.material.SetColor("_Color", Color.red);
        Debug.Log("colorChanged reached");
    }
    */
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
            wand.SetActive(true);
            //colorChange();
        }
    }
}
