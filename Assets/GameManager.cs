using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables
    public static GameManager instance;
    public DialogueSystem dialogueSystem;
    public ItemContainer inventorycontainer;
    public Player[] players;
    public Player currentPlayer;

    public Transform canvas;
    public GameObject itemInfoPrefab;
    private GameObject currentItemInfo = null;

    //Awake will initialize the player in the scene
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
        
    }

    //Start will add the current player to the array 
    private void Start()
    {
        if(players.Length > 0)
        {
            currentPlayer = players[0];
            
        }
    }

    //Set player will set currently selected player
    public void SetPlayer(Player players)
    {
        currentPlayer = players;
    }

    public void DisplayItemInfo(string itemName, string itemDescription, Vector2 buttonPos) 
    {
        if(currentItemInfo != null) 
        {
            Destroy(currentItemInfo.gameObject);
        }

        currentItemInfo = Instantiate(itemInfoPrefab, buttonPos, Quaternion.identity, canvas);
        currentItemInfo.GetComponent<ItemInfo>().SetUp(itemName, itemDescription);
    }

    public void DestroyItemInfo()
    {
        if(currentItemInfo != null) 
        {
            Destroy(currentItemInfo.gameObject);
        }
    }


   
}
