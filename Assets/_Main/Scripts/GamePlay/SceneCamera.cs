using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCamera : MonoBehaviour
{
    private void Update()
    {
        Vector3 inpDir = new Vector3(0,0,0);
        if(Input.GetKey(KeyCode.W)) inpDir.z = +1f;
        if(Input.GetKey(KeyCode.S)) inpDir.z = -1f;
        if(Input.GetKey(KeyCode.A)) inpDir.x = -1f;
        if(Input.GetKey(KeyCode.D)) inpDir.x = +1f;

        Vector3 moveDir = transform.forward * inpDir.z + transform.right * inpDir.x;
        float movespeed = 50f;
        transform.position += moveDir*movespeed*Time.deltaTime;
    }
}
