using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTCameraMovement : MonoBehaviour {


    [SerializeField]
    GameObject targ;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, 15f);
        //  transform.rotation = Vector3.RotateTowards(transform.rotation, targ.transform.rotation,, Movement.speed);
    }
}
