/*
 Devun Schneider
 Prototype 2
 Creates a reference to a text game object and changes its contents based on score variable
 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    //create text Game object variable
    public Text textbox;

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //set text reference
        textbox = GetComponent<Text>();
        //initialize textbox/text game object
        textbox.text = "Score: 0";

    }

    // Update is called once per frame
    void Update()
    {
        //update text game object
        textbox.text = "Score: " + score;
    }
}
