/****
 * Created by: Bridget Kurr
 * Date Created: June 5, 2022
 * 
 * Last Edited by:
 * Last Edit:
 * 
 * Description: Manages the UI elements for the menu scenes
 ****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //libraries for UI components
using TMPro; //libraries for TextMeshPro components

public class HUDScript : MonoBehaviour
{

    [Header("Stats Placement")]
    public TMP_Text levelCountTextbox; //textbox for level count
    public TMP_Text livesTextbox; //textbos for the lives
    public TMP_Text healthTextbox; //textbox for health
    public TMP_Text scoreTextbox; //textbox for the score
    public TMP_Text highScoreTextbox; //textbox for highscore
    public TMP_Text collectableCountTextbox; //texbox for amount of collectables
    public TMP_Text TimerTextbox; //textbox for Timer display
    public TMP_Text fastestTimeTextbox; //textbox for the Fastest time

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
