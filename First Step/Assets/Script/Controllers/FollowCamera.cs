using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform targetObejct;        // ����ٴ� Ÿ�� ������Ʈ�� Transform

    void Start()
    {
  
    }

    void LateUpdate()
    {
        transform.position = new Vector3(targetObejct.position.x, targetObejct.position.y, -10f);
    }
}
