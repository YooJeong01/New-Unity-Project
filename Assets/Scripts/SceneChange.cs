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
        Debug.Log("시작하기");
        SceneManager.LoadScene("Scene_Select");
    }
    
    public void OnClickPlay()
    {
        Debug.Log("캐릭터 선택 완료 및 게임 시작");
        
        SceneManager.LoadScene("Scene_Start");
    }

    public void OnClickLoad()
    {
        Debug.Log("이어하기");
    }

    public void OnClickInfo()
    {
        Debug.Log("개발자 정보");
        SceneManager.LoadScene("Scene_imformation");
    }

    public void OnClickInfoBack()
    {
        Debug.Log("돌아가기");
        SceneManager.LoadScene("Scene_MainMenu");
    }

    public void OnClickBack()
    {
        Debug.Log("챕터3 플레이 화면으로 돌아가기");
        SceneManager.LoadScene("Chapter3");
    }


}
