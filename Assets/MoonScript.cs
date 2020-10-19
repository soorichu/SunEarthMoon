using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonScript : MonoBehaviour
{
    public Transform earth;
    void Update()
    {
        earth = GameObject.Find("Earth").transform;
        transform.RotateAround(earth.position, Vector3.up, 1);  //공전
        transform.Rotate(new Vector3(0f, -1f, 0f) * Time.deltaTime); //자전
    }
}
