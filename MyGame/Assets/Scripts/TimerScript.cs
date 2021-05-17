using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TimerScript : MonoBehaviour
{
    float timer;
    float seconds;
    float minutes;
    [SerializeField] TextMeshProUGUI stopWatchText;
    bool start;
    [SerializeField] TextMeshProUGUI hsText;
    [SerializeField] TextMeshProUGUI scoreText;
    

    void Start()
    {
        start = true;
        timer = 0;
        hsText.text = PlayerPrefs.GetFloat("HighScore",0).ToString("00:00");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        StopWatchCalc();
    }

    void StopWatchCalc()
    {
        if (start)
        {
            timer += Time.deltaTime;
            seconds = (int)(timer % 60);
            minutes = (int)(timer / 60);

            stopWatchText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
            scoreText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
            


        }
    }

    public void ResetHs()
    {
        PlayerPrefs.DeleteAll();
    }

    public void stopTimer()
    {
        start = false;

        if (timer < PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", timer);
            hsText.text = minutes.ToString("00") + ":" + seconds.ToString("00"); ;
        }

        
    }

    public void startTimer()
    {
        start = true;
    }


}
