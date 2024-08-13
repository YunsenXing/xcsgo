using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    [SerializeField]
    private float speed = 5f;


    [SerializeField]
    private float MouseSensitivity = 8f;


    [SerializeField]
    private PlayerController playerController;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // 获取水平方向和竖直方向是否移动
        // 有三个值，0表示不动，-1 / 1 表示朝 X 方向移动
        float xMov = Input.GetAxisRaw("Horizontal");
        float yMov = Input.GetAxisRaw("Vertical");

        // 获取速度 Vector 表示3维向量
        Vector3 velocity = (transform.right * xMov + transform.forward * yMov).normalized * speed;
        playerController.Move(velocity);

        float xMouse = Input.GetAxisRaw("Mouse X");
        float yMouse = Input.GetAxisRaw("Mouse Y");

        Vector3 yRotation = new Vector3(0f,xMouse,0f) * MouseSensitivity;
        Vector3 xRotation = new Vector3(-yMouse,0f,0f) * MouseSensitivity;


        playerController.Rotate(yRotation,xRotation);

    }
}
