using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counting3sec : MonoBehaviour
{
    public Text TimeCount;
    public float TimeCost=3;
    public GameObject thisPanel;
    GameObject obj;
    GameObject playerController;
    bool isPause;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindWithTag("Player");
        isPause = playerController.GetComponent<PlayerController>().isPause;
        isPause = false;
        Time.timeScale = 1;


    }

    // Update is called once per frame
    void Update()
    {
        playerController.transform.position = new Vector3(0, 0, -7.5f);
        
        
        if (TimeCost > 0)
        {
            TimeCost -= Time.deltaTime;
            TimeCount.text = $"{TimeCost:N0}";
        }

        StartCoroutine(GameStart());
    }

    private IEnumerator GameStart()
    {
        yield return new WaitForSeconds(3f);
        TimeCount.text = "Game Start!";
        yield return new WaitForSeconds(0.5f);
        thisPanel.SetActive(false);
        Initialize();
    }

    void Initialize()
    {
        obj = GameObject.FindWithTag("Tagger");
        obj.GetComponent<TaggerController>().GameStart();
        obj.GetComponent<TaggerController>().anim.SetBool("IsStart", true);
    }
}
