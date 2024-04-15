using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class clockPuzzle : MonoBehaviour
{
    //the buttons are gonna have the tag 1, 2, 3, 4

    int counter = 0;
    bool buttonPushed = false;
    bool correctButton = false;
    GameObject button;
    int button2 = 0;
    List<int> buttons = new List<int>();


    //button.tag == counter
    public class buttons
    {
        public int id
        {
            get; set;
        }

        public bool buttonPressed()
        {
            button = GameObject.FindWithTag("button");
            return button != null;

        }

        void buttonOrderCheck()
        {
            if (buttonPressed()) //when button is integrated
            {
                if (button == counter)
                {
                    correctButton = true;
                    playHappySound();
                    counter++;
                }
                else
                {
                    correctButton = false;
                    playSadSound();
                    counter = 0;
                }
            }
        }

        void Update()
        {
            buttonOrderCheck(); //ändra funktionsnamn

        }

        void playHappySound()
        {

        }
        void playSadSound()
        {

        }


    }
}
