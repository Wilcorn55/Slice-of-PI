using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public GameObject player;
    public ItemContainer inventorycontainer;

    public Player[] players;
    public Player currentPlayer;

    private void Start()
    {
        if(players.Length > 0)
        {
            currentPlayer = players[0];
        }
    }

    public void SetPlayer(Player players)
    {
        currentPlayer = players;
    }
}
