using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //public Text timerTxt;
    public float time = 3f;
    private float selectCountdown;
    public GameObject[] countdownImg;

    void Start()
    {
        selectCountdown = time;
    }

    void Update()
    {
        int count;
        if (Mathf.Floor(selectCountdown) <= 0)
        {
            // Count 0일때 동작할 함수 삽입
            //timerTxt.text = "";


            countdownImg[2].SetActive(false);
            countdownImg[1].SetActive(false);
            countdownImg[0].SetActive(false);
        }
        else
        {
            selectCountdown -= Time.deltaTime;
            //timerTxt.text = Mathf.Floor(selectCountdown).ToString();
            count = (int)Mathf.Floor(selectCountdown);
            if(count==3)
            {
                countdownImg[2].SetActive(true);
                countdownImg[1].SetActive(false);
                countdownImg[0].SetActive(false);
            }
            else if (count==2)
            {
                countdownImg[2].SetActive(false);
                countdownImg[1].SetActive(true);
                countdownImg[0].SetActive(false);
            }
            else if (count == 1)
            {
                countdownImg[2].SetActive(false);
                countdownImg[1].SetActive(false);
                countdownImg[0].SetActive(true);
            }
        }
    }
}
