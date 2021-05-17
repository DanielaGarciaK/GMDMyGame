using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField]
     float speed = 0.5f;
     float offset;
     Material mat;

    private void Start()
    {
        mat = GetComponent<Renderer>().material;
    }
    private void Update()
    {
        offset += (Time.deltaTime * speed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
