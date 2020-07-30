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
    private Text scoreText, soulsText, gradeText, winScoreText;

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
        Time.timeScale = 1;
        soulsText.text = "" + 0;
        StartCoroutine(ExampleCoroutine());
    }

    void Update()
    {
        if (Health.health ==0)
        {
            GameOver();
        }

    }


    public void IncreaseSouls()
    {
        currentSouls++;
        soulsText.text = "" + currentSouls;
        winScoreText.text = "" + currentSouls;
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
        winScoreText.text = "" + currentSouls;
        Time.timeScale = 0;

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

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(52);

        //After we have waited 5 seconds print the time again.
        GameWin();
    }
}
