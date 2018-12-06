using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTCameraCursor : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float cameraY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * 2f;
        float cameraX = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * 2f;

        gameObject.transform.localEulerAngles = new Vector3(cameraX, cameraY, 0);
    }
}
