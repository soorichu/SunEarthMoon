using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthScript : MonoBehaviour
{
    public Transform sun;
    void Update()
    {
        sun = GameObject.Find("Sun").transform;
        transform.RotateAround(sun.position, Vector3.up, 1);  //공전
        transform.Rotate(new Vector3(0f, -2f, 0f) * Time.deltaTime); //자전
    }
}
