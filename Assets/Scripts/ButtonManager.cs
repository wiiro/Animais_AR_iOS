using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public SceneLoader sceneLoader;
  
    #region Main Menu Buttons
    public void Play()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(1);
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(2));
        StaticVariables.currentScene = 2;
    }

    public void Bioma()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(1);
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(3));
        StaticVariables.currentScene = 3;
    }

    public void Settings()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(1);
        SceneManager.UnloadSceneAsync(2);
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(4));
        StaticVariables.currentScene = 4;
    }

    public void ComoFunciona()
    {
        SceneManager.LoadScene(5, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(1);
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(5));
        StaticVariables.currentScene = 5;
    }

    public void Sair()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(2);
        SceneManager.UnloadSceneAsync(3);
        SceneManager.UnloadSceneAsync(4);
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(1));
        StaticVariables.currentScene = 1;
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    #endregion

    #region Social Media Buttons
    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/affagiofamilia/");
    }

    public void Facebook()
    {
        Application.OpenURL("https://www.facebook.com/affagiofamilia/");
    }

    public void WebSite()
    {
        Application.OpenURL("http://www.affagio.com.br");
    }
    #endregion
}
