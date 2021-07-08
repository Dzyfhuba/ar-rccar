using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceTimer : MonoBehaviour
{
    public Text raceTime;

    float startTime = 0f;
    float currentTime = 0f;

    public bool isStart = false;

    // Start is called before the first frame update
    void Start()
    {
        raceTime = gameObject.GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart)
        {
            currentTime = Time.time - startTime;
            raceTime.text = FloatToTime(currentTime);
        }
    }

    public string FloatToTime(float time)
    {
        TimeSpan temp = TimeSpan.FromSeconds(time);
        return temp.ToString("mm':'ss':'fff");
    }

    public void startTheTime()
    {
        isStart = true;
        startTime = Time.time;
    }
}
