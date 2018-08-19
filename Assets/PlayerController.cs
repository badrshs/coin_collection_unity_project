using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;             //Floating point variable to store the player's movement speed.
    public int coin = 0;
    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public AudioClip impact;
    private int coin_number;

    public Text WinText;
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
        coin_number = GameObject.FindGameObjectsWithTag("gold").Length;
    }

    // Update is called once per frame
    void Update () {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));


        rb2d.AddForce(movement * speed);

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("gold"))
        {
            AudioSource.PlayClipAtPoint(impact, transform.position);
            coin_number--;
            Destroy(other.gameObject);

            if (coin_number == 0)
            {
                WinText.text = "You Win";
            }

        }



    }


}
