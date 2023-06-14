using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    public Vector2 lastMortionVector;
    public bool moving;

    /*[SerializeField]
    GameObject codePanel, closedSafe, openedSafe;*/

    public static bool isSafeOpened = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        /*codePanel.SetActive(false);
        closedSafe.SetActive(true);
        openedSafe.SetActive(false);*/
    }


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        movement = new Vector2(
            horizontal,
            vertical
            );


        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        /*if (isSafeOpened) {

            codePanel.SetActive(false);
            closedSafe.SetActive(false);
            openedSafe.SetActive(true);

        }*/

        if (horizontal != 0 || vertical != 0) 
        {
            lastMortionVector = new Vector2(
                horizontal,
                vertical
                ).normalized;
        }


    }

    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime) ;
    }

    /*
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals ("Safe") && !isSafeOpened)
        {
            codePanel.SetActive(true);
            Debug.Log("Working enter");
        }
    }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Safe"))
        {
            codePanel.SetActive(false);
            Debug.Log("Working exit");
        }


    }
    */

}
