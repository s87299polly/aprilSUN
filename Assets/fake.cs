using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fake : MonoBehaviour {




         public float y;

    void Update()
    {


        //Vector3 pos = transform.position;
        //pos.x = pos.x + 0.02f;
        //transform.position = pos;

        Transform transform = GetComponent<Transform>();
        Vector3 angle = new Vector3(0, y * Time.deltaTime, 0);
        transform.Rotate(angle);
    }
}
