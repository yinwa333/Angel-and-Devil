using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformerController : MonoBehaviour
{
    [SerializeField]
    //This number is from dragging player to edge of screen, the X value of the screen + player
    private float xLimit = 2.64f;

    //Speed of character movement and height of the jump. Set these values in the inspector.
    public float speed;

    //Assigning a variable where we'll store the Rigidbody2D component.
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        //Sets our variable 'rb' to the Rigidbody2D component on the game object where this script is attached.
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //this will love the character's movement in both positive and negative x values, y value, and z.
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xLimit, xLimit), transform.position.y, transform.position.z);

        //Movement code for left and right arrow keys.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(+speed, rb.velocity.y);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Souls"))
        {
            ScoreSystem.instance.IncreaseSouls();

            //HERE IS COLLECT ANIMATION EFFECT

            //GameObject soulEffect = ObjectPooling.instance.GetPooledObject("SoulEffect");
            //soulEffect.transform.position = transform.position;
            //soulEffect.SetActive(true);

            other.gameObject.SetActive(false);
        }

    }


}
