using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;

    public float minimumVertical = -45.0f;
    public float maximumVertical = 45.0f;

    public float verticalRot = 0;
    // Update is called once per frame
    void Update()
    {
        if(axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
        else if(axes == RotationAxes.MouseY)
        {
            verticalRot -= Input.GetAxis("Mouse Y") * sensitivityVert;
            verticalRot = Mathf.Clamp(verticalRot, minimumVertical, maximumVertical);
            
            //float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            //float horizontalRot = transform.localEulerAngles.y + delta;
            transform.localEulerAngles = new Vector3(verticalRot, 0, 0);
        }
        
    }
}
