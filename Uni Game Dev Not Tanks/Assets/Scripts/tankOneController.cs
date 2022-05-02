using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankOneController : MonoBehaviour
{
    //declare variables
    public TurnManager turnman;

    public float runSpeed = 1f;

    float horizontalMove = 0f;

    public static int turretPos = 3;

    public static int health = 100;

    public Sprite turretPosSprite1;
    public Sprite turretPosSprite2;
    public Sprite turretPosSprite3;
    public Sprite turretPosSprite4;
    public Sprite turretPosSprite5;
    public Sprite turretPosSprite6;
    public Sprite turretPosSprite7;
    public Sprite turretPosSprite8;
    public Sprite turretPosSprite9;
    public Sprite turretPosSprite10;
    public Sprite turretPosSprite11;
    public Sprite turretPosSprite12;

    public static bool tankRight = true;

    // Update is called once per frame
    void Update()
    {
        //when no health destroy object
        if (health < 1)
        {
            Destroy(gameObject);
        }
        // wait for players turn
        if (TurnManager.turn == false)
        {
            //play movement sound while moving
            if (Input.GetButtonDown("Horizontal"))
            {

                GetComponent<AudioSource>().Play();

            }
            else if (Input.GetButtonUp("Horizontal"))
            {

                GetComponent<AudioSource>().Pause();

            }

            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;


            //move turret
            if (Input.GetButtonDown("TurretDown"))
            {
                turretPos = turretPos + 1;
                if (turretPos == 13)
                {

                    turretPos = 1;

                }

                // check turret position and move firing position
                if (turretPos == 1)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite1;
                }
                else if (turretPos == 2)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite2;
                }
                else if (turretPos == 3)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite3;
                }
                else if (turretPos == 4)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite4;
                }
                else if (turretPos == 5)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite5;
                }
                else if (turretPos == 6)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite6;
                }
                else if (turretPos == 7)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite7;
                }
                else if (turretPos == 8)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite8;
                }
                else if (turretPos == 9)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite9;
                }
                else if (turretPos == 10)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite10;
                }
                else if (turretPos == 11)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite11;
                }
                else if (turretPos == 12)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite12;
                }

            }
            //move turret
            if (Input.GetButtonDown("TurretUp"))
            {
                turretPos = turretPos - 1;
                if (turretPos == 0)
                {

                    turretPos = 12;

                }
                //check turret position and move firing position
                if (turretPos == 1)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite1;
                }
                else if (turretPos == 2)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite2;
                }
                else if (turretPos == 3)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite3;
                }
                else if (turretPos == 4)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite4;
                }
                else if (turretPos == 5)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite5;
                }
                else if (turretPos == 6)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite6;
                }
                else if (turretPos == 7)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite7;
                }
                else if (turretPos == 8)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite8;
                }
                else if (turretPos == 9)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite9;
                }
                else if (turretPos == 10)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite10;
                }
                else if (turretPos == 11)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite11;
                }
                else if (turretPos == 12)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = turretPosSprite12;
                }

            }

        }

    }
    // if hit by missile take damage
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Missile" && TurnManager.turn == true)
        {
            health = health - 10;
            TurnManager.missileLanded = true;
            Debug.Log(health);
        }

    }

    // Player movement
    void FixedUpdate()
        {
        if (TurnManager.turn == false)
        {

            float horizontal = Input.GetAxis("Horizontal");
            transform.Translate(horizontal * Time.deltaTime * runSpeed, 0f, 0f);

            if (horizontal > 0 && !tankRight)
            {
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
                tankRight = true;
            }
            else if (horizontal < 0 && tankRight)
            {
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
                tankRight = false;
            }

        }
        }
}
