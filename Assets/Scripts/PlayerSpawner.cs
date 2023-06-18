using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject currentPlayer;

    private void Start()
    {
        GameObject newPlayer = Instantiate(GameManager.instance.currentPlayer.prefab, transform.position, Quaternion.identity);
        PlayerCameraController.mainCam.target = newPlayer.transform;
    }

}
