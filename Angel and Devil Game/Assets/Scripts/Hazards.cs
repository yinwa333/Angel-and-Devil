using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazards : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
                //this puts a message in the Console that the impact has hit
            Debug.Log("Collided with Ground");
                //This is script that makes the object disappear when hitting the ground!
            gameObject.SetActive(false);
        }
    }
}
