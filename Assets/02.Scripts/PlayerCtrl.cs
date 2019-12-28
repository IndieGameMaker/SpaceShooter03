using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");  //Up/Down  -1.0f ~ 0.0f ~ +1.0f
        Debug.Log(v);

        //transform.position += new Vector3(0, 0, 0.1f);
        //transform.position = transform.position + new Vector3(0, 0, 0.1f);  
        transform.Translate( Vector3.forward * 0.1f);

        /*
        단위벡터/정규화벡터/Normalized Vector
        Vector3.forward = Vector3(0, 0, 1)
        Vector3.up      = Vector3(0, 1, 0)
        Vector3.right   = Vector3(1, 0, 0)

        Vector3.one     = Vector3(1, 1, 1)
        Vector3.zero    = Vector3(0, 0, 0)
        */

    }


}
