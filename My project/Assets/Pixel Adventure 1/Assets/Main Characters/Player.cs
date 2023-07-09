using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb2d;
    SpriteRenderer sR;
    private float timeAcum = 0;
    public float velocidad = 1f;
    public float salto = 3f;
    private bool controlJump = true;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        rb2d = GetComponent<Rigidbody2D>();
        sR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timeAcum += Time.deltaTime;
        if (timeAcum > 0.5f)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }

        gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(velocidad, 0);
            sR.flipX = false;
        }

        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-velocidad, 0);
            sR.flipX = true;
        }

        if ((Input.GetKeyDown("up") || Input.GetKeyDown("space")) && controlJump)
        {
            rb2d.velocity = new Vector2(0,salto);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        controlJump = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        controlJump = false;
    }
}
