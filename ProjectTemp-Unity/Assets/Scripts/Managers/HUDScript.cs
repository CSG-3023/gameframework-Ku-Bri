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
    GameManager gm; //reference to game manager

    [Header("Stats Placement")]
    public TMP_Text levelCountTextbox; //textbox for level count
    public TMP_Text livesTextbox; //textbos for the lives
    public TMP_Text healthTextbox; //textbox for health
    public TMP_Text scoreTextbox; //textbox for the score
    public TMP_Text highScoreTextbox; //textbox for highscore
    public TMP_Text collectableCountTextbox; //texbox for amount of collectables
    public TMP_Text TimerTextbox; //textbox for Timer display
    public TMP_Text fastestTimeTextbox; //textbox for the Fastest time

    //GM Data
    private int level;
    private int totalLevels;
    private int lives;
    private int score;
    private int highscore;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GM; //find the game manager
        //reference to level info
        level = gm.gameLevelsCount;
        totalLevels = gm.gameLevels.Length;

    } //end Start()


    // Update is called once per frame
    void Update()
    {
        GetGameStats();
        SetHUD();

    } //end Update()

    void GetGameStats()
    {
        lives = gm.Lives;
        score = gm.Score;
        highscore = gm.HighScore;

    } //end GetGameStats()

    void SetHUD()
    {
        //if textbox exists update value

        if (levelCountTextbox) { levelCountTextbox.text = "Lives " + lives; }
        if (scoreTextbox) { scoreTextbox.text = "Score " + score; }
        if (highScoreTextbox) { highScoreTextbox.text = "High Score " + highscore; }

    } //end SetHUD()
} //end HUDScript
