using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIndicator : MonoBehaviour
{
    public float rotateSpeed = 2;
    void Update()
    {
        transform.Rotate(new Vector3(0, rotateSpeed, 0));
    }
}
