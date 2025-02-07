using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    { 
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    { 
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

   // public void Quit()
  //  { 
  //  
  //  }





}
