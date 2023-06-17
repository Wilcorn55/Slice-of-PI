using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    private void Start()
    {
        Instantiate(GameManager.instance.currentPlayer.prefab, transform.position, Quaternion.identity);   
    }

}
