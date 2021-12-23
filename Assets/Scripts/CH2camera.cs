using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CH2camera : MonoBehaviour
{
    public Transform[] target; //����ٴ� ĳ���� Transform
   
    private Transform tr; // ī�޶�
    public float positionX, positionY, positionZ = 1; // unity���� ���� ��ġ ����
    private void Start()
    {
        tr = GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        
        tr.position = new Vector3(target[(int)DataMgr.instance.currentCharacter].position.x - positionX, target[(int)DataMgr.instance.currentCharacter].position.y - positionY, target[(int)DataMgr.instance.currentCharacter].position.z - positionZ);
        tr.LookAt(target[(int)DataMgr.instance.currentCharacter]);
    }
}
