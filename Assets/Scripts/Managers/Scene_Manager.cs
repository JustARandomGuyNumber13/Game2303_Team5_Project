using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public void GoToScene(int index)
    { 
        SceneManager.LoadScene(index);
    }
    public void CloseApplication()
    {
        Application.Quit();
    }
}
