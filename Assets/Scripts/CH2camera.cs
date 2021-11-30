using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CH2camera : MonoBehaviour
{
    public Transform target; //����ٴ� ĳ���� Transform
    private Transform tr; // ī�޶�
    public float positionX, positionY, positionZ = 1; // unity���� ���� ��ġ ����
    private void Start()
    {
        tr = GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        tr.position = new Vector3(target.position.x - positionX, target.position.y - positionY, target.position.z - positionZ);
        tr.LookAt(target);
    }
}
