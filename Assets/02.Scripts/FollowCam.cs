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

    // Update is called once per frame
    void Update()
    {
        
    }
}
