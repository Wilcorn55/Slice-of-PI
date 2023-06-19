using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public DialogueSystem dialogueSystem;
    public ItemContainer inventorycontainer;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);


        } else
        {
            Destroy(gameObject);
        }

        dialogueSystem = DialogueSystemManager.instance.dialogueSystem;
    }

    public GameObject player;
   

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
