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

    public float timeStart = 0f;

    public GameObject timer;

    // Start is called before the first frame update
    void Start()
    {
        currentRaceTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        currentRaceTime = Time.time - timeStart;
    }

    public void StartRace()
    {
        timeStart = Time.time;
    }

    public void FinishRace()
    {
        raceDuration = Time.time - timeStart;
        timer.GetComponentInChildren<Text>().text = timer.GetComponent<RaceTimer>().FloatToTime(raceDuration);
        timer.GetComponent<RaceTimer>().isStart = false;
    }
}
