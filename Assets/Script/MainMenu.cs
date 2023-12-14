using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    int chosen_index;

    [SerializeField] private TMP_Dropdown dropdown; //receiving the value of the dropdown UI
    public void playGame() //Starting the game
    {
        int index = dropdown.value; //receiving the index of the chosen song. The index of each scene represents different game
        SceneManager.LoadScene(index+1); //loading the scene, playing game
    }
    public void quitGame()
    {
        Application.Quit(); //Terminating the game
    }
}
