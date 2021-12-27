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
        Debug.Log("엑스버튼 누름");
        SceneManager.LoadScene("Chapter3");
    }
    public void OnClickX__Button()
    {
        Debug.Log("엑스버튼 누름");
        SceneManager.LoadScene("Chapter3");
    }
}
