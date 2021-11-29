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
    void Start()
    {
        text = GetComponent<Text>();    
    }

    // Update is called once per frame
    void Update()
    {
        text.text = count.ToString();
        if(count>=100)
        {
            score[0].SetActive(true);
            score[1].SetActive(false);
            SceneManager.LoadScene("Chapter2");
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
