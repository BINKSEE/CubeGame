using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// THIS SCRIPT IS ATTACHED TO THE DATA MANAGER OBJECT PRESENT IN ALL THE SCENES

public class KeepData : MonoBehaviour
{
    // STATIC so they are preserved between classes
    public static string PlayerName;
    public static float PlayingSpeed;

    public InputField PlayerNameInput;
    public Slider speedSlider;
    //not using a "lives" option

    public Text showPlayerName; // don't forget to drop the hierarchy objects in the script slots in the inspector
    public Text playingSpeedText;

    /*void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // don't destroy this game object when a new scene is loaded.
    }*/
    public void UpdateName() //executed in each letter change
    {
        PlayerName = PlayerNameInput.text; // assign new input text to a string
        Debug.Log(PlayerName); // prints updated name to the log on each letter change
        showPlayerName.text = PlayerName; // show string in the textbox just to see that it works in intro scene
    }
    public void ShowName() // method for the show name button on intro
    {
        
    }
}
