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
        float h = Input.GetAxisRaw("Horizontal"); //����
        if ((isTouchRight && h == 1)|| (isTouchLeft && h == -1))
            h = 0;

        float v = Input.GetAxisRaw("Vertical"); //����
        if ((isTouchTop && v == 1) || (isTouchBottom && v == -1))
            v = 0;

        Vector3 curPos = transform.position; //ĳ���� ���� ��ġ
        Vector3 nextPos = new Vector3(h, v, 0)*speed*Time.deltaTime; //���� ��ġ (Ʈ������ �̵��� �׻� ��ŸŸ���� ���ؾ���. �����̵��� ���x)

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

            if (collision.gameObject.name == "Ŀ��")
            { 
                Score.count += 5;
            }
            else if (collision.gameObject.name == "����")
            {
                Score.count += 5;
            }
            else if (collision.gameObject.name == "����")
            {
                Score.count -= 5;
            }
            else if (collision.gameObject.name == "Ż��")
            {
                Score.count -= 5;
            }
            else if (collision.gameObject.name == "�޴���")
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
