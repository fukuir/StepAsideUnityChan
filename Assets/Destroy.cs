﻿using UnityEngine;
using System.Collections;


public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
