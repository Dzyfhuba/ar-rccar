using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;
    public AudioSource count, go;
    public bool playCountdown;
    public VehicleControl vehicleControl;
    public FinishScreenScript finishScreenScript;
    public void startTheGame()
    {
        vehicleControl.activeControl = true;
        finishScreenScript.startRace = true;
    }

    public void playTheCountdown()
    {
        playCountdown = true;
    }

    private void Start()
    {
        vehicleControl.activeControl = false;

        if (playCountdown)
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while(countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            count.Play();
            yield return new WaitForSeconds(2f);

            countdownTime--;
        }

        countdownDisplay.text = "GO!";
        go.Play();
        startTheGame();
		
		/* Call the code to "begin" your game here.
		 * For example, mine allows the player to start
		 * moving and starts the in game timer.
         */
		// GameController.instance.BeginGame();

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
    }
}
