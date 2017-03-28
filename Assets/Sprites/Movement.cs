using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Movement : MonoBehaviour
{

    private float _movspeed = 10.0f;
    private float _horz;


    void FixedUpdate()
    {
        _horz = Input.GetAxis("Horizontal");

        transform.position += Vector3.right * _horz * _movspeed * Time.deltaTime;

    }



}
