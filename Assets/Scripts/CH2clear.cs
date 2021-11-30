using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CH2clear : MonoBehaviour
{

    Rigidbody2D rigid;
    void Awake()
    {

        rigid = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("CH2clear");
        //clear
    }
}
