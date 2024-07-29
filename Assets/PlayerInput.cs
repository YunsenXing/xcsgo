using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    private PlayerController playerController;


    // Start is called before the first frame update
    void Start()
    {
        
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

    }
}
