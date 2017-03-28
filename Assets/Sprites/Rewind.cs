using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rewind : MonoBehaviour
{

    private int index = 0;
    private bool rewinding;
    private ArrayList _movements = new ArrayList();


	// Update is called once per frame
	private void FixedUpdate () {
	    if (!rewinding)
	    {
	        _movements.Add(transform.position);
	        index++;
	    }

	    if (index > _movements.Count - 1)
	    {
	        index = _movements.Count;
	    }

	    if (Input.GetKey(KeyCode.Space))
	    {
	        rewinding = true;
	        RewindTime();
	    }
	    else
	    {
	        rewinding = false;

	    }



	}

    public void RewindTime()
    {
        index--;
        if (index > 0)
        {
            transform.position = (Vector3) _movements[index];
            _movements.RemoveAt(index);
        }
    }
}


//Code Structuur
//
//Rekening houden met de lengte van de array
//