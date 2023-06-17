using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectionUI : MonoBehaviour
{
    public GameObject playerPrefab;

    public Transform prevPlayer;
    public Transform selectedPlayer;

    private void Start()
    {
        foreach(Player p in GameManager.instance.players)
        {
            GameObject option = Instantiate(playerPrefab, transform);
            Button button = option.GetComponent<Button>();

            button.onClick.AddListener(() =>
            {
                GameManager.instance.SetPlayer(p);
                if (selectedPlayer != null)
                {
                    prevPlayer = selectedPlayer;
                }

                selectedPlayer = option.transform;
            });

            Image image = option.GetComponentInChildren<Image>();
            image.sprite = p.icon;
        }
    }

    private void Update()
    {
        if(selectedPlayer != null)
        {
            selectedPlayer.localScale = Vector3.Lerp(selectedPlayer.localScale, new Vector3(1.2f, 1.2f, 1.2f), Time.deltaTime * 10);
        }

        if (prevPlayer != null)
        {
            prevPlayer.localScale = Vector3.Lerp(prevPlayer.localScale, new Vector3(1f, 1f, 1f), Time.deltaTime * 10);
        }
    }
}
