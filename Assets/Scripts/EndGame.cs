using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject textBoxLoose;
    public GameObject textBoxWin;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Terrain") // if the player fall and touch the terrain
        {
            Time.timeScale = 0.0f; //Stop the game
            textBoxLoose.SetActive(true);     //Make the canvas with loose text appear
        }
    }

    public void Win()
    {
        //if the player is still alive at the end of the chrono
        Time.timeScale = 0.0f; //Stop the game
        textBoxWin.SetActive(true);//Make the canvas with win text appear
    }

}
