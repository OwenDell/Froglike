using UnityEngine;

public class Pause_Script : MonoBehaviour
{
    bool isPaused = false;
    public GameObject pauseMenuUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0f : 1f;

       // pauseMenuUI.SetActive(isPaused);

        Time.timeScale = 0f;
        Physics.autoSimulation = false;

        Time.timeScale = 1f;
        Physics.autoSimulation = true;
    }





}
