using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MathiasSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        int currentSceneIndex = activeScene.buildIndex;
        Debug.Log(currentSceneIndex);

        int maxScenesCountInBuild = SceneManager.sceneCountInBuildSettings;
        int nextSceneIndexToLoad = (currentSceneIndex + 1)%maxScenesCountInBuild;

        SceneManager.LoadScene(currentSceneIndex+1);
    }
}
