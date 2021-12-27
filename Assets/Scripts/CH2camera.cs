using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CH2camera : MonoBehaviour
{
    public Transform[] target; //따라다닐 캐릭터 Transform
   
    private Transform tr; // 카메라
    public float positionX, positionY, positionZ = 1; // unity에서 직접 위치 조절
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
