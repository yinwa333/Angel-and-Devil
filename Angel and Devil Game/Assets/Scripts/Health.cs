using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static Health instance;

    public GameObject heart1, heart2, heart3, deadHeart1, deadHeart2, deadHeart3;
    public static int health;

    void Start()
    {
        Time.timeScale = 1;

        health = 3;

        heart1.gameObject.SetActive(true);
        deadHeart1.gameObject.SetActive(true);

        heart2.gameObject.SetActive(true);
        deadHeart2.gameObject.SetActive(true);

        heart3.gameObject.SetActive(true);
        deadHeart3.gameObject.SetActive(true);
    }

    void Update()
    {
        if (health > 3)
            health = 3;

        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                deadHeart1.gameObject.SetActive(false);
                deadHeart2.gameObject.SetActive(false);
                deadHeart3.gameObject.SetActive(false);
                break;

            case 2:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                deadHeart1.gameObject.SetActive(true);
                deadHeart2.gameObject.SetActive(false);
                deadHeart3.gameObject.SetActive(false);
                break;

            case 1:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(true);
                deadHeart1.gameObject.SetActive(true);
                deadHeart2.gameObject.SetActive(true);
                deadHeart3.gameObject.SetActive(false);
                break;

            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                deadHeart1.gameObject.SetActive(true);
                deadHeart2.gameObject.SetActive(true);
                deadHeart3.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;
        }
    }

}
