using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuRules : MonoBehaviour
{
    public string NextScene;

    public void DisplayRules()
    {
        SceneManager.LoadScene(NextScene);
    }
}
