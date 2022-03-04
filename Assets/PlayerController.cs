using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    AudioClip[] taggerSound;
    AudioSource audioSource;

    public GameObject successPanel;
    public GameObject diePanel;
    GameObject obj;

    bool isStart;
    bool isDead;
    public bool isSuccess;
    public bool isPause;

    Vector3 lastPos;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindWithTag("Tagger");
        taggerSound = obj.GetComponent<TaggerController>().taggerSound;
        audioSource = obj.GetComponent<TaggerController>().audioSource;
        isStart = obj.GetComponent<TaggerController>().isStart;
        isDead = obj.GetComponent<TaggerController>().isDead;
        isPause = obj.GetComponent<TaggerController>().isPause;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CallMe()
    {
        StartCoroutine(IsPlayerMoving());
    }

    private IEnumerator IsPlayerMoving()
    {
        lastPos = this.gameObject.transform.position;
        for (float f = 0; f < 2.0f; f += 0.1f)
        {
            StartCoroutine(Check(lastPos));
            yield return new WaitForSeconds(0.1f);
            if (isDead && !diePanel.activeSelf)
            {
                Die();
            }
        }
    }

    private IEnumerator Check(Vector3 lastPos)
    {
        yield return new WaitForSeconds(0.1f);

        if (lastPos != this.gameObject.transform.position)
        {
            isDead = true;
        }
    }

    public void Success()
    {
        successPanel.SetActive(true);
        isSuccess = true;
        audioSource.Stop();
        if (isPause)
        {
            Time.timeScale = 0;
            isPause = false;
        }
    }

    public void Die()
    {
        diePanel.SetActive(true);
        audioSource.clip = taggerSound[8];
        audioSource.Play();
        if (isPause)
        {
            Time.timeScale = 0;
            isPause = false;
        }
    }
}
