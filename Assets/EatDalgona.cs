﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatDalgona : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(this.gameObject);
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
