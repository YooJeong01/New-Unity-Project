using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Get : MonoBehaviour
{
    int sceneIndex;
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

        public void getData()
    {
        Debug.Log("�ڷ� ȹ��");
        SceneManager.LoadScene("Chapter3");
    }

}
