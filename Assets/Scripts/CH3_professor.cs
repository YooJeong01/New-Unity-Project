using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CH3_professor : MonoBehaviour
{
    int count = 0;
    public GameObject[] charPrefabs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CH3_select.isFired&&count==0)
        {
            charPrefabs[0].SetActive(false);
            charPrefabs[1].SetActive(true);
            count = 1;
        }
    }
}
