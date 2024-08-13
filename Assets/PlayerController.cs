using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private Camera UserViewCamera;

    private Vector3 velocity = Vector3.zero;   // 移动速度
    private Vector3 yRotation = Vector3.zero;  // 旋转角色
    private Vector3 xRotation = Vector3.zero;  // 旋转摄像机

    public void Move(Vector3 _velocity){
        velocity = _velocity;
    }
    
    public void Rotate(Vector3 _yRotation, Vector3 _xRotation){
        yRotation = _yRotation;
        xRotation = _xRotation;
    }

    private void PerformMovement(){
        if(velocity != Vector3.zero){
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }

    private void PerformRotate(){
        if(yRotation != Vector3.zero){
            rb.transform.Rotate(yRotation);
        }

        if(xRotation != Vector3.zero){
            UserViewCamera.transform.Rotate(xRotation);
        }
    }

    private void FixedUpdate(){
        PerformMovement();
        PerformRotate();
    }


}
