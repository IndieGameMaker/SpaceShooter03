using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamGizmo : MonoBehaviour
{
    public Color color = Color.yellow;
    public float radius = 0.3f;

    void OnDrawGizmos()
    {
        Gizmos.color = this.color;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
