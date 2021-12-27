using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CH3_select : MonoBehaviour
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
    public void OnClickAssign()
    {
        Debug.Log("노트북 누름");
        SceneManager.LoadScene("CH3_assign");
    }
    public void OnClickSafe()
    {
        Debug.Log("금고 열기");
        SceneManager.LoadScene("CH3_safe");
    }
    public void OnClickburn()
    {
        Debug.Log("자료 태우기(화덕 클릭)");
        SceneManager.LoadScene("CH3_burn");
    }
    public void OnClickclear()
    {
        Debug.Log("연구실 탈출");
        SceneManager.LoadScene("clear");
    }
}