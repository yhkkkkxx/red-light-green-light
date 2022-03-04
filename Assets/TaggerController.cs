using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaggerController : MonoBehaviour
{
    public AudioClip[] taggerSound;
    public AudioSource audioSource;
    //public AudioSource turnAudioSource;

    public Animator anim;

    public GameObject player;
    public GameObject successPanel;
    public GameObject diePanel;
    GameObject timer;
    GameObject playerController;

    public bool isStart = false;
    public bool isDead = false;
    public bool ShowDiePanel = false;
    public bool isPause = true;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameStart()
    {

        timer = GameObject.FindWithTag("TimeCount");
        timer.GetComponent<Timer>().isStart = true;
        isStart = true;

        StartCoroutine(Tagger());
    }

    private IEnumerator Tagger()
    {
        while (true)
        {
            anim = GetComponent<Animator>();
            anim.SetBool("IsChanting", true);

            Chant();
            yield return new WaitForSeconds(audioSource.clip.length);

            anim.SetBool("IsChanting", false);
            anim.SetBool("IsLookingBack", false);
            Turn();
            yield return new WaitForSeconds(anim.GetCurrentAnimatorStateInfo(0).length);


            playerController = GameObject.FindWithTag("Player");
            playerController.GetComponent<PlayerController>().CallMe();
            yield return new WaitForSeconds(2);

            yield return new WaitForSeconds(0.5f);
            anim.SetBool("IsLookingBack", true);
            
        }
    }

    void Chant()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = taggerSound[Random.Range(0, taggerSound.Length - 2)];
        audioSource.Play();
    }

    void Turn()
    {
        anim.SetBool("IsLookingBack", false);
        audioSource.clip = taggerSound[7];
        audioSource.Play();
    }
}
