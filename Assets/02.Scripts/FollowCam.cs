using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    //추적 대상
    public Transform targetTr;
    public float moveSpeed = 10.0f;
    public float rotateSpeed = 10.0f;
    
    [Range(3.0f, 7.0f)]
    public float distance = 5.0f;
    [Range(3.0f, 10.0f)]
    public float height   = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void LateUpdate()
    {
        //카메라의 위치값을 계산
        Vector3 camPos = targetTr.position - (targetTr.forward * distance) + (targetTr.up * height);

        //부드러운 이동
        transform.position = Vector3.Lerp(transform.position
                                        , camPos
                                        , Time.deltaTime * moveSpeed);

        //부드러운 회전
        transform.rotation = Quaternion.Slerp(transform.rotation
                                            , targetTr.rotation
                                            , Time.deltaTime * rotateSpeed);
        //카메라 회전
        transform.LookAt(targetTr.position);
    }
}
