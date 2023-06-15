using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] PlayerData playerData;

    public Gender chosenGender;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SetGenderMale()
    {
        chosenGender = Gender.Male;
        playerData.playerCharacterGender = chosenGender;
    }

    public void SetGenderFemale()
    {
        chosenGender = Gender.Female;
        playerData.playerCharacterGender = chosenGender;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
