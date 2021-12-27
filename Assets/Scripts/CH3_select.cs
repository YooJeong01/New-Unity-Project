using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CH3_select : MonoBehaviour
{
    public static bool isFired = false;
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
        Debug.Log("��Ʈ�� ����");
        SceneManager.LoadScene("CH3_assign");
    }
    public void OnClickSafe()
    {
        Debug.Log("�ݰ� ����");
        SceneManager.LoadScene("CH3_safe");
    }
    public void OnClickFire()
    {
        
        Debug.Log("ȭ��");
        if (GetData.isDataOptain)
        {
            isFired = true;
            SceneManager.LoadScene("CH3_fire");
            
        }
    }
    public void OnClickDoor()
    {
        Debug.Log("�� ����");
        if(isFired)
        SceneManager.LoadScene("CH3_door");
    }

}