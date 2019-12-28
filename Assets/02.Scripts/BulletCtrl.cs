using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddForce : 글로벌 좌표계로 힘을 가하는 함수
        rb.AddRelativeForce(Vector3.forward * 500.0f); //로컬좌표계 기준으로 힘을 가하는 함수
    }

}
