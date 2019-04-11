using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class countdowntimer : MonoBehaviour
{
    /*float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text countdownText;*/
    public Text timerText;
    private float startTime;
    public static float TimeLeft = 120f;


    // Start is called before the first frame update
    void Start()
    {
        //currentTime = startingTime;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //currentTime -= 1 * Time.deltaTime;
        //countdownText.text = currentTime.ToString ();
        TimeLeft -= Time.deltaTime;

        //float t = Time.time - startTime;

        string minutes = (TimeLeft / 60).ToString("00");


        string seconds = (TimeLeft % 60).ToString("00");

        timerText.text = minutes + ":" + seconds;
    }

    //TimeLeft should be in GameManager script for now, inside countdown timer script

}
