using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishScreenScript : MonoBehaviour // cukup sampai di sini wkwk
{
    public bool startRace;
    public bool finishRace;
    public float currentRaceTime = 0f;
    public float raceDuration = 0f;
    public Text record;
    // Start is called before the first frame update
    void Start()
    {
        currentRaceTime = 0f;;
    }

    // Update is called once per frame
    void Update()
    {
        if (startRace)
        {
            currentRaceTime += Time.deltaTime;
        }
    }

    public void FinishRace()
    {
        //if (finishRace)
        //{
        //    raceDuration = currentRaceTime;
        //    record.text = "Speed Record: " + raceDuration;
        //}
        
    }
}
