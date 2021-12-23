using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CH1start_button : MonoBehaviour
{
    public GameObject cartoon1;
    public GameObject btn;
    int characterSeleted = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(characterSeleted==1)
        {
            if(Input.GetMouseButtonDown(0))
                SceneManager.LoadScene("Scene_Start");
        }
    }
    public void OnClickPlay()
    {
        cartoon1.SetActive(true);
        Destroy(btn);
        characterSeleted = 1;
    }

}
