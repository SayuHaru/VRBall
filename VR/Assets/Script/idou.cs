using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idou : MonoBehaviour
{
    private Vector3 last;
    // Start is called before the first frame update
    void Start()
    {
        last = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 1.0f + last.x, last.y, last.z);
    }
}
