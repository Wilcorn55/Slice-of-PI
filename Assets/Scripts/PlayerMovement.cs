using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables
    public static float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    public Vector2 lastMortionVector;
    public bool moving;

    /*[SerializeField]
    GameObject codePanel, closedSafe, openedSafe;*/

    public static bool isSafeOpened = false;

    //Start is called before the first frame update
    //Start will get the rigidbody of the player
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    //Update is called once per frame
    //Update will continuously update the players movement
    void Update()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying) 
        {
            return;
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        movement = new Vector2(
            horizontal,
            vertical
            );


        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
        animator.SetFloat("Speed", movement.sqrMagnitude);



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



}
