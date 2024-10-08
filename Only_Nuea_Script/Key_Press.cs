using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key_Press : MonoBehaviour
{
    public bool Paused = false;
    public GameObject PauseMenuCanvas;
    public GameObject MusicMenu;
    public GameObject PauseMenu;
    public int SelectScene;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Paused)
            {
                Play();
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }

            else
            {
                Stop();
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }

    public void Stop()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        PauseMenuCanvas.SetActive(true);
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }

    public void Play()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PauseMenuCanvas.SetActive(false);
        MusicMenu.SetActive(false);
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    public void OpenMusicMenu()
    {
        if(PauseMenu)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            MusicMenu.SetActive(true);
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
            Paused = true;
        }
    }

    public void CloseMusicMenu_Return()
    {
        if(MusicMenu)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            MusicMenu.SetActive(false);
            PauseMenu.SetActive(true);
            Time.timeScale = 1f;
            Paused = true;
        }
    }

    public void CloseMusicMenu_Exit()
    {
        if(MusicMenu)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            MusicMenu.SetActive(false);
            PauseMenu.SetActive(false);
            PauseMenuCanvas.SetActive(false);
            Time.timeScale = 0f;
            Paused = false;
        }
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(SelectScene);
    }
}
