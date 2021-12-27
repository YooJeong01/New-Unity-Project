using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GetData : MonoBehaviour
{
    public void OnClickData()
    {
        Debug.Log("ÀÚ·á È¹µæ");
        SceneManager.LoadScene("Chapter3");
    }
}
