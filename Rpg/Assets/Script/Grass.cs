using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour {

    public Vector3 OnMouseDown()
    {
        Debug.Log(transform.position);
        
        return transform.position;
    }

}
