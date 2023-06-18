using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject currentPlayer;

    //Start is called before the first frame update
    //Start will create a clone of the chosen character from the CharacterSelectionUI and put it into the scene as the player
    //The camera will also follow this clone
    private void Start()
    {
        GameObject newPlayer = Instantiate(GameManager.instance.currentPlayer.prefab, transform.position, Quaternion.identity);
        PlayerCameraController.mainCam.target = newPlayer.transform;
    }

}
