using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem instance;

    public bool gameOver = false;

    [SerializeField]
    private Text scoreText, soulsText;

    [SerializeField]
    private GameObject soulsCollected, menu, gameOverMenu;

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


    public void IncreaseSouls()
    {
        currentSouls++;
        soulsText.text = "" + currentSouls;

    }

    public void GameOver()
    {
        if (Health.health == 0)
        {
            gameOver = true;
            soulsCollected.SetActive(false);
            gameOverMenu.SetActive(true);
            scoreText.text = "" + currentSouls;
        }

    }


}
