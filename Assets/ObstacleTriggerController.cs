using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleTriggerController : MonoBehaviour
{
    public GameObject diePanel;
    GameObject playerController;

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag=="Player")
        {
            playerController = GameObject.FindWithTag("Player");
            playerController.GetComponent<PlayerController>().Die();
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
