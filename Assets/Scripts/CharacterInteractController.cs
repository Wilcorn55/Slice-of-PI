using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteractController : MonoBehaviour
{
    //Variables
    PlayerMovement PlayerMovement;
    Rigidbody2D rgbd2d;
    [SerializeField] float offsetDistance = 1f;
    [SerializeField] float sizeOfInteractableArea = 1.2f;
    Character character;

    //Awake will get the players position
    private void Awake()
    {
        PlayerMovement = GetComponent<PlayerMovement>();
        rgbd2d = GetComponent<Rigidbody2D>();
        character = GetComponent<Character>();
    }

    //Update will check if the player pressed the trigger button
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Interact();
        }
    }

    //Interact will check if there is anything around the player that they can interact with
    private void Interact() 
    {
        Vector2 position = rgbd2d.position + PlayerMovement.lastMortionVector * offsetDistance;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(position, sizeOfInteractableArea);

        foreach (Collider2D c in colliders) 
        {
            Interactable hit = c.GetComponent<Interactable>();
            if (hit != null) 
            {
                hit.Interact(character);
                break;
            }
        }
    
    }

}
