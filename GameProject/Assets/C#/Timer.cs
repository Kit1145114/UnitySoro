﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float time;

    void Start()
    {
        time = 0;
    }
    void Update()
    {
        if (Goal.goal == false)
        {
            time += Time.deltaTime;
        }
        int t = Mathf.FloorToInt(time);
        Text uiText = GetComponent<Text>();
        uiText.text = "Time:" + t;
    }
}
