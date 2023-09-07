using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform targetObejct;        // 따라다닐 타겟 오브젝트의 Transform

    void Start()
    {
  
    }

    void LateUpdate()
    {
        transform.position = new Vector3(targetObejct.position.x, targetObejct.position.y, -10f);
    }
}
