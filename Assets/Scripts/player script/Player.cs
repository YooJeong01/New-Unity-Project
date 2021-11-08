using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public bool isTouchTop;
    public bool isTouchBottom;
    public bool isTouchLeft;
    public bool isTouchRight;
    public int count;

    void Start()
    {
        Invoke("OnDisable", 5.0f);
    }
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal"); //수평
        if ((isTouchRight && h == 1)|| (isTouchLeft && h == -1))
            h = 0;

        float v = Input.GetAxisRaw("Vertical"); //수직
        if ((isTouchTop && v == 1) || (isTouchBottom && v == -1))
            v = 0;

        Vector3 curPos = transform.position; //캐릭터 현재 위치
        Vector3 nextPos = new Vector3(h, v, 0)*speed*Time.deltaTime; //다음 위치 (트랜스폼 이동은 항상 델타타임을 곱해야함. 물리이동은 상관x)

        transform.position = curPos + nextPos;
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            switch (collision.gameObject.name)
            {
                case "Top":
                    isTouchTop = true;
                    break;
                case "Bottom":
                    isTouchBottom = true;
                    break;
                case "Right":
                    isTouchRight = true;
                    break;
                case "Left":
                    isTouchLeft = true;
                    break;
            }
        }
        else if (collision.gameObject.tag == "item")
        {
            collision.gameObject.SetActive(false);

            if (collision.gameObject.name == "커피")
            { 
                Score.count += 5;
            }
            else if (collision.gameObject.name == "계산기")
            {
                Score.count += 5;
            }
            else if (collision.gameObject.name == "게임")
            {
                Score.count -= 5;
            }
            else if (collision.gameObject.name == "탈주")
            {
                Score.count -= 5;
            }
            else if (collision.gameObject.name == "휴대폰")
            {
                Score.count -= 5;
            }
        }
    }
    void OnDisable()
    {
        gameObject.SetActive(true);
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            switch (collision.gameObject.name)
            {
                case "Top":
                    isTouchTop = false;
                    break;
                case "Bottom":
                    isTouchBottom = false;
                    break;
                case "Right":
                    isTouchRight = false;
                    break;
                case "Left":
                    isTouchLeft = false;
                    break;
            }
        }
    }
}
