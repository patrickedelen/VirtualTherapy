﻿using UnityEngine;
using System.Collections;

public class Flame : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollision(Collider other)
    {
        Debug.Log("Trigger fired");
        GetComponent<ParticleSystem>().Stop();
    }
}
