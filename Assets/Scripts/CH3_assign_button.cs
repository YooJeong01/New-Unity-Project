using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CH3_assign_button : MonoBehaviour
{
    int sceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;

    }

    // Update is called once per frame
    void Update()
    {
        


    }
    public void OnClickXButton()
    {
        Debug.Log("������ư ����");
        SceneManager.LoadScene("Chapter3");
    }
    public void OnClickX__Button()
    {
        Debug.Log("������ư ����");
        SceneManager.LoadScene("Chapter3");
    }
}
