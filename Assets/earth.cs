using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth : MonoBehaviour {

    public float y;

	
	
	// Update is called once per frame
	void Update () {

        Transform transform = GetComponent<Transform>();
        Vector3 angle = new Vector3(0, y, 0);
        transform.Rotate(angle);


    }
}
