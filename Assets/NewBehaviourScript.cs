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
        Debug.Log("�����ϱ�");
        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void OnClickLoad()
    {
        Debug.Log("�̾��ϱ�");
    }

    public void OnClickInfo()
    {
        Debug.Log("������ ����");
        SceneManager.LoadScene(sceneIndex + 2);
    }

}
