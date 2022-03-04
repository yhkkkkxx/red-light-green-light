using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachRedLine : MonoBehaviour
{
    public GameObject invisibleWall;
    GameObject playerController;
    GameObject eatDalgona;

    private void OnTriggerEnter(Collider other)
    {
        playerController.GetComponent<PlayerController>().Success();
    }

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Dalgona") == null)
        {
            invisibleWall.SetActive(false);
        }
        
    }
}
