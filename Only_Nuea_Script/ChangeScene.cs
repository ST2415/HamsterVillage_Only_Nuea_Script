using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int SelectScene;
    public static ChangeScene CS;
    //[SerializeField] Animator startT;

    public void LoadGame()
    {
    //    StartCoroutine(LoadLevel());
        SceneManager.LoadScene(SelectScene);
    }

    //IEnumerator LoadLevel()
    //{
    //    startT.SetTrigger("Start");
    //    yield return new WaitForSeconds(2f);
    //    SceneManager.LoadScene(SelectScene);
    //}
    
    public void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
