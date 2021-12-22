using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CH3_assign : MonoBehaviour
{
    public GameObject[] arrows;
    public GameObject[] codes;
    public GameObject popup;
    int[] answer = { 4, 3, 2, 2, 4, 1, 2, 3, 1, 3, 1, 4 };
    
    int key = 0;
    int count = -1;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.anyKeyDown== true&&count<12)
        {
            
            if (Input.GetKey(KeyCode.LeftArrow) == true)
                key = 1;
            if (Input.GetKey(KeyCode.UpArrow) == true)
                key = 2;
            if (Input.GetKey(KeyCode.DownArrow) == true)
                key = 3;
            if (Input.GetKey(KeyCode.RightArrow) == true)
                key = 4;
            count++;
            if (answer[count] == key)
            {
                arrows[count].SetActive(false);
                codes[count].SetActive(false);
                if(count==11)
                {
                    popup.SetActive(true);
                }
            }
            else
            {
                count = -1;

                for (int i=0;i<12;i++)
                {
                    arrows[i].SetActive(true);
                    codes[i].SetActive(true);
                }
            }
        }
        
       
    }
}
