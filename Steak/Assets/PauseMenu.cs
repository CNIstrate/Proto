using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;
    public PlayerController_FSM pc_fsm;
    bool isActive;


    void Start()
    {
        isActive = false;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isActive == false)
        {
            Pause();
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && isActive == true)
        {
            Resume();
        }
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        isActive = true;
        Cursor.visible = true;
        pc_fsm.canRotate = false;
        Time.timeScale = 0f;

    }

    public void Resume()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        isActive = false;
        pc_fsm.canRotate = true;
        Cursor.visible = false;
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        pc_fsm.canRotate = true;
        Cursor.visible = false;
        isActive = false;
        Physics.IgnoreLayerCollision(9, 10, false);
    }

    public void QuitToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    
}