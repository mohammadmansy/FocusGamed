using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TimeCounter : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    bool finishCountTime = false;
    public string minutes, seconds;
    public float EndTime = 30;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void startTheTimer()
    {
        Invoke("startTime", 10);
        startTime = Time.time;

    }

    public void stopTheTimer()
    {

        finishCountTime = true;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        minutes = ((int)t / 60).ToString();
        seconds = (t % 60).ToString("f2");
        timerText.text = minutes + ":" + seconds;
        if (Time.time > EndTime)
        {
            SceneManager.LoadScene("YourScore");
        }

    }
}
