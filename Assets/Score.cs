using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    
    Text text;
    public static int count;
    public GameObject[] score;
    public GameObject cartoon2;
    int isClear = 0;
    void Start()
    {
        text = GetComponent<Text>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (isClear == 1)
        {
            if (Input.GetMouseButtonDown(0))
                SceneManager.LoadScene("Chapter2");
        }
        text.text = count.ToString();
        if(count>=100)
        {
            score[0].SetActive(false);
            score[1].SetActive(false);
            cartoon2.SetActive(true);
            count += 500;
            isClear = 1;
            //SceneManager.LoadScene("Chapter2");
        }
        else if(count>=85)
        {
            score[0].SetActive(false);
            score[1].SetActive(true);
            score[2].SetActive(false);
        }
        else if (count >= 70)
        {
            score[1].SetActive(false);
            score[2].SetActive(true);
            score[3].SetActive(false);
        }
        else if (count >= 55)
        {
            score[2].SetActive(false);
            score[3].SetActive(true);
            score[4].SetActive(false);
        }
        else if (count >= 40)
        {
            score[3].SetActive(false);
            score[4].SetActive(true);
            score[5].SetActive(false);
        }
        else if (count >= 25)
        {
            score[4].SetActive(false);
            score[5].SetActive(true);
            score[6].SetActive(false);
        }
        else if (count >= 10)
        {
            score[5].SetActive(false);
            score[6].SetActive(true);
            score[7].SetActive(false);
        }
        else if (count >= -5)
        {
            score[6].SetActive(false);
            score[7].SetActive(true);
            score[8].SetActive(false);
        }
        else
        {
            score[7].SetActive(false);
            score[8].SetActive(true);
            score[9].SetActive(false);

        }
    }
}
