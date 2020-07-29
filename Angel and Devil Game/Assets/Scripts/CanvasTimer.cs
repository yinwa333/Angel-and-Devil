using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasTimer : MonoBehaviour
{
    public GameObject AngelicoText1;
    public GameObject AngelicoText2;
    public GameObject AngelicoText3;
    public Animator animator;
   
    void Start()
    {
        AngelicoText1.SetActive(false);
        AngelicoText2.SetActive(false);
        AngelicoText3.SetActive(false);
    }
    void Update()
    {
        if (Health.health == 2)
        {
            AngelicoText2.SetActive(true);
            
        }

        if (Health.health == 1)
        {
            AngelicoText3.SetActive(true);
            
        }

    }
        
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(26);

        //After we have waited 5 seconds print the time again.
        AngelicoText1.SetActive(true);
        
    }
}
