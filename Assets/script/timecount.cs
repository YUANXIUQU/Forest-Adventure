using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class timecount : MonoBehaviour
{
    public bool playing = false;
    public float starttime = 0;
    public TMP_Text timer;
    public TMP_Text wintime;

    // Update is called once per frame
    void Update()
    {
        if (playing) 
        {
            float elaspsedtime = Time.time - starttime;
            timer.text = "Time: " + elaspsedtime.ToString("0") + " s";
            if(show_info.winstate == true)
            {
                wintime.text = "Well Done " + elaspsedtime.ToString("0") + " s !";
                Destroy(timer);
            }
        }
    }

    public void Startgametime()
    {
        starttime = Time.time;
        playing = true;
    }

    public void Endgametime()
    {
        playing = false;
    }
}
