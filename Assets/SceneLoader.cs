using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    List<AsyncOperation> allScenes = new List<AsyncOperation>();
    const int sceneMax = 6;
    bool doneLoadingScenes = false;
    public Text texto;
    public Slider barraDeCarregamento;
    public GameObject Canvas;

    void Start()
    {
        StartCoroutine(loadAllScene());
        
    }


    IEnumerator loadAllScene()
    {
        yield return new WaitForSecondsRealtime(1);
        //Loop through all scene index
        for (int i = 1; i < sceneMax; i++)
        {
            AsyncOperation scene = SceneManager.LoadSceneAsync(i, LoadSceneMode.Additive);
            //scene.allowSceneActivation = false;

            //Add to List so that we don't lose the reference
            allScenes.Add(scene);

            //Wait until we are done loading the scene
            while (scene.progress < 0.9f)
            {
                Debug.Log("Carregando tela #:" + i + "| Progresso: " + scene.progress);
                //texto.text = "Carregando tela #:" + i;
                yield return null;
            }
            barraDeCarregamento.value = 0.15f * i;
            //Load the next one in the loop
        }

        doneLoadingScenes = true;
        //texto.text = "Finalizando....";
        barraDeCarregamento.value = 0.95f;
        yield return new WaitForSecondsRealtime(3);
        OnFinishedLoadingAllScene();
    }

    public void enableScene(int index)
    {
        //Activate the Scene
        //allScenes[index].allowSceneActivation = true;
        SceneManager.LoadSceneAsync(index, LoadSceneMode.Additive);
        StaticVariables.currentScene = index;

    }

    void OnFinishedLoadingAllScene()
    {
        Debug.Log("Done Loading All Scenes");
        StaticVariables.currentScene = 1;
        Canvas.SetActive(false);
    }
}
