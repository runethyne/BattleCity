using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnariadImpl : MonoBehaviour
{
    public Vector3 dir;
    private float speed = 50;

    private void Update()
    {

        float dist = speed * Time.deltaTime;

        Vector3 deltaPos = dir * dist;

        transform.position += deltaPos;


    }
}
