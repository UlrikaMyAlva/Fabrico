using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    //Maybe not mono behaviout?

    public void startButton() {
        Console.WriteLine("Move to next scene");
        //You can also have SceneManager.LoadScene("NameOfScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void loadButton() {
        Console.WriteLine("Load saved game");
    }

    public void settingsButton() {
        Console.WriteLine("Move to settings");
    }

    public void exitButton() {
        Console.WriteLine("Exiting the game");
        //Application.Quit;
    }

}
