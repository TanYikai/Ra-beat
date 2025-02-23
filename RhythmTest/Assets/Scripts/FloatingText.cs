﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour {

    private float destroyTime = 1f;
    private Vector3 randomizeIntensity = new Vector3(0.15f, 0, 0);

	// Use this for initialization
	void Start () {
        Destroy(gameObject, destroyTime);
        
        transform.localPosition += new Vector3(Random.Range(-randomizeIntensity.x, randomizeIntensity.x),
        Random.Range(-randomizeIntensity.y, randomizeIntensity.y),
        Random.Range(randomizeIntensity.z, randomizeIntensity.z)); 
	}
	
}
