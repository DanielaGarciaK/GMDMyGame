using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    private Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(target.position.x, -5.5f, 5.5f),
            Mathf.Clamp(target.position.y, -3f, 3.8f),
            transform.position.z);
    }
}
