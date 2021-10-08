using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
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

    public void OnClickNewGame()
    {
        Debug.Log("시작하기");
        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void OnClickLoad()
    {
        Debug.Log("이어하기");
    }

    public void OnClickInfo()
    {
        Debug.Log("개발자 정보");
        SceneManager.LoadScene(sceneIndex + 2);
    }

}
