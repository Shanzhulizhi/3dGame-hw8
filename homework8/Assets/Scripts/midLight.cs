﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class midLight : MonoBehaviour {

    ParticleSystem exhaust;
    float size = 5f;

    // Use this for initialization
    void Start()
    {
        exhaust = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        size = size * 0.999f;
        var main = exhaust.main;
        main.startSize = size;
    }

}
