using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GetData : MonoBehaviour
{
    public static bool isDataOptain = false;
    public void OnClickData()
    {
        Debug.Log("�ڷ� ȹ��");
        isDataOptain = true;
        SceneManager.LoadScene("Chapter3");
    }
}
