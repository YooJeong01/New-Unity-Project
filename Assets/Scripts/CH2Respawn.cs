using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CH2Respawn : MonoBehaviour
{
    public GameObject[] charPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      //  if(DataMgr.instance.currentCharacter == 0)
      if(1==0)
        {
            charPrefabs[0].SetActive(true);
            charPrefabs[1].SetActive(false);
        }
        else
        {
            charPrefabs[0].SetActive(false);
            charPrefabs[1].SetActive(true);
        }
    }
}
