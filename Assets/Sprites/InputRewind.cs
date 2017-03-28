using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputRewind : MonoBehaviour
{
    private Rewind _rewind;


	// Use this for initialization
	void Start ()
	{
	    _rewind = gameObject.GetComponent<Rewind>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.Space))
	    {
	        _rewind.RewindTime();

	    }
	}
}
