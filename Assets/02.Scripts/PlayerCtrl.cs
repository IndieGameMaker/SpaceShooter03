﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Anims
{
    public AnimationClip idle;
    public AnimationClip runForward;
    public AnimationClip runBackward;
    public AnimationClip runLeft;
    public AnimationClip runRight;
    public AnimationClip[] dies;
}


public class PlayerCtrl : MonoBehaviour
{

    public Anims anims;
    public float speed = 6.0f;

    private Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        //anim.Play("Idle");
        anim.Play(anims.idle.name);
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");  //Up/Down  -1.0f ~ 0.0f ~ +1.0f
        float h = Input.GetAxis("Horizontal"); //Left/Right  -1.0f ~ 0.0f ~ +1.0f
        float r = Input.GetAxis("Mouse X");
        //Debug.Log(v);

        //transform.position += new Vector3(0, 0, 0.1f);
        //transform.position = transform.position + new Vector3(0, 0, 0.1f);  

        Vector3 dir = (Vector3.forward * v) + (Vector3.right * h);
        transform.Translate(dir.normalized * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * Time.deltaTime * 80.0f * r);

        //transform.Translate( Vector3.forward * 0.1f * v);
        //transform.Translate( Vector3.right * 0.1f * h);

        /*
        단위벡터/정규화벡터/Normalized Vector
        Vector3.forward = Vector3(0, 0, 1)
        Vector3.up      = Vector3(0, 1, 0)
        Vector3.right   = Vector3(1, 0, 0)

        Vector3.one     = Vector3(1, 1, 1)
        Vector3.zero    = Vector3(0, 0, 0)
        */


        if (v >= 0.1f) //전진 애니메이션
        {
            anim.CrossFade(anims.runForward.name, 0.3f);
        }
        else if (v <= -0.1f) //후진 애니메이션
        {
            anim.CrossFade(anims.runBackward.name, 0.3f);
        }
        else if (h >= 0.1f) //오른쪽 이동
        {
            anim.CrossFade(anims.runRight.name, 0.3f);
        }
        else if (h <= -0.1f) //왼쪽 이동
        {
            anim.CrossFade(anims.runLeft.name, 0.3f);
        }
        else
        {
            anim.CrossFade(anims.idle.name, 0.3f);
        }
    }


}
