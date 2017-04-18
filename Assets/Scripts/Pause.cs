﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool paused = false;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)
            {
                Time.timeScale = 0;
                paused = true;
            }
            else
            {
                Time.timeScale = 1;
                paused = false;
            }
        }
	}
}