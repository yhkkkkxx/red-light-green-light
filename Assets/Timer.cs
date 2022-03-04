using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerTxt;
    int min;
    public float sec;

    bool isDead = false;
    bool isSuccess = false;
    public bool isStart = false;
    public Text successTime;

    GameObject playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    public void Update()
    {
        if (isStart)
        {
            StartTimer();
        }
    }

    public void StartTimer()
    {
        if (!isDead)
        {
            sec+= Time.deltaTime;
            timerTxt.text = string.Format("{0:D2}:{1:D2}", min, (int)sec);

            if ((int)sec > 59)
            {
                sec = 0;
                min++;
            }

            isSuccess=playerController.GetComponent<PlayerController>().isSuccess;

            if (isSuccess)
            {
                successTime.text = timerTxt.text;
            }
        }
    }
}
