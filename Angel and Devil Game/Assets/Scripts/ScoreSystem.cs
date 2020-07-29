using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem instance;

    public bool gameOver = false;
    public bool gameWin = false;

    [SerializeField]
    private Text scoreText, soulsText, gradeText;

    [SerializeField]
    private GameObject soulsCollected, menu, gameOverMenu, gameWinMenu;

    private int currentSouls;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        soulsText.text = "" + 0;
    }

    void Update()
    {
        if (Health.health ==0)
        {
            GameOver();
        }

        //THIS IS THE IF STATEMENT FOR WHEN THE PLAYER WINS

        //if (currentSouls)
    }


    public void IncreaseSouls()
    {
        currentSouls++;
        soulsText.text = "" + currentSouls;

    }


    public void GameOver()
    {
        gameOver = true;
        gameOverMenu.SetActive(true);
        soulsCollected.SetActive(false);
        scoreText.text = "" + currentSouls;
    }

    public void GameWin()
    {
        gameWin = true;
        gameWinMenu.SetActive(true);
        soulsCollected.SetActive(false);
        scoreText.text = "" + currentSouls;

        if (currentSouls == 48)
        {
            gradeText.text = "C";
        }

        if (currentSouls == 49)
        {
            gradeText.text = "B";
        }

        if (currentSouls == 50)
        {
            gradeText.text = "A";
        }
    }


}
