using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public static SceneManagement Instance = null; 
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
