using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    GameObject playerController;
    GameObject taggerController;
    GameObject timer;
    bool isPause;
    AudioSource audioSource;

    public void OnRestartButtonClickEvent()
    {
        isPause = false;
        audioSource.UnPause();
        Time.timeScale = 1;

        timer = GameObject.FindWithTag("TimeCount");
        timer.GetComponent<Timer>().isStart = true;

        SceneManager.LoadScene("gamescene");
    }

    public void OnBackToTitleButtonClickEvent()
    {
        SceneManager.LoadScene("startscene");
    }

    public void OnPauseButtonClickEvent()
    {
        isPause = true;
        audioSource.Pause();
        Time.timeScale = 0;

    }

    public void OnResumeButtonClickEvent()
    {
        isPause = false;
        Time.timeScale = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindWithTag("Player");
        isPause = playerController.GetComponent<PlayerController>().isPause;
        taggerController = GameObject.FindWithTag("Tagger");
        audioSource = taggerController.GetComponent<TaggerController>().audioSource;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
