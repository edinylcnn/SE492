using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    
    void Start()
    {
    }

    
    void Update()
    {
    }

    public void OpenScene(int sceneIndex)
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneIndex);
    }
}