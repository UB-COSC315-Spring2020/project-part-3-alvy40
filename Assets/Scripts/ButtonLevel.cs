using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonLevel : MonoBehaviour
{
    // For the UI in the main menu to start level
    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }
}
