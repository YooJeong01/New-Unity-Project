using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
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

    public void OnClickChoice()
    {
        Debug.Log("�����ϱ�");
        SceneManager.LoadScene("Scene_Select");
    }
    
    public void OnClickPlay()
    {
        Debug.Log("ĳ���� ���� �Ϸ� �� ���� ����");
        
        SceneManager.LoadScene("Scene_Start");
    }

    public void OnClickLoad()
    {
        Debug.Log("�̾��ϱ�");
    }

    public void OnClickInfo()
    {
        Debug.Log("������ ����");
        SceneManager.LoadScene("Scene_imformation");
    }

    public void OnClickInfoBack()
    {
        Debug.Log("���ư���");
        SceneManager.LoadScene("Scene_MainMenu");
    }

    public void OnClickBack()
    {
        Debug.Log("é��3 �÷��� ȭ������ ���ư���");
        SceneManager.LoadScene("Chapter3");
    }


}
