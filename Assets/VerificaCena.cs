using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VerificaCena : MonoBehaviour
{

    public GameObject master;

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (StaticVariables.currentScene == SceneManager.GetActiveScene().buildIndex)
            master.SetActive(true);
        else
            master.SetActive(false);

        if(SceneManager.GetSceneByBuildIndex(2).isLoaded && StaticVariables.currentScene == 1)
            SceneManager.UnloadSceneAsync(2);
        if (SceneManager.GetSceneByBuildIndex(3).isLoaded && StaticVariables.currentScene == 1)
            SceneManager.UnloadSceneAsync(3);
        if (SceneManager.GetSceneByBuildIndex(4).isLoaded && StaticVariables.currentScene == 1)
            SceneManager.UnloadSceneAsync(4);
        if (SceneManager.GetSceneByBuildIndex(5).isLoaded && StaticVariables.currentScene == 1)
            SceneManager.UnloadSceneAsync(5);

        if(StaticVariables.currentScene == 1)
            SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(1));
    }
}
