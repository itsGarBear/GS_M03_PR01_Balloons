using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepUpRight : MonoBehaviour
{
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, Time.deltaTime * speed);
    }
}
