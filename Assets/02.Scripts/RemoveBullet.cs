using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)
    {
        //충돌한 Collider의 Tag 값을 비교
        // gameObject.tag
        // collider.tag
        if (coll.collider.tag == "BULLET")
        {
            Destroy(coll.gameObject);
        }
    }
}
