using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelect : MonoBehaviour
{
    public GameObject[] skins;
    public int selectedPlayerSkin;

    private void Awake()
    {
        selectedPlayerSkin = PlayerPrefs.GetInt("selectedPlayerSkin", 0);
        foreach (GameObject player in skins)
        {
            player.SetActive(false);
        }
        skins[selectedPlayerSkin].SetActive(true);
    }

}