using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToCorrectAnswer = 10f;

    public bool loadNextQuestion;
    public float fillFraction;

    public bool isAnsweringQuesion;
    float timervalue;
    void Update()
    {
        updatetimer();
    }

    public void CancleTimer()
    {
        timervalue = 0;
    }

    void updatetimer()
    {
        timervalue -= Time.deltaTime;

        if (isAnsweringQuesion)
        {
            if (timervalue > 0)
            {
                fillFraction = timervalue / timeToCompleteQuestion;
            }

            else
            {
                isAnsweringQuesion = false;
                timervalue = timeToCorrectAnswer;
            }
        }
        else
        {
            if (timervalue > 0)
            {
                fillFraction = timervalue / timeToCorrectAnswer;
            }
            else
            {
                isAnsweringQuesion = true;
                timervalue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
        // Debug.Log(isAnsweringQuesion + ":" + timervalue + "=" + fillFraction);
    }
}
