using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float STEP = 5.0f;
    Rigidbody2D rigid2D;
    public int MAX_JUMP_COUNT = 1;
    private int jumpCount = 0;
    private bool jump = false;
    public float JUMP_POWER;
    private bool isGrounded = false;
    [SerializeField] ContactFilter2D filter2d;


    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        // 右に一定の速度で移動
        this.transform.position += new Vector3(STEP * Time.deltaTime, 0, 0);

        if (jumpCount < MAX_JUMP_COUNT && Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }

        if (jump)
        {
            rigid2D.AddForce(Vector2.up * JUMP_POWER);
            jumpCount++;
            jump = false;
        }

        if (rigid2D.IsTouching(filter2d))
        {
            // 地面に着地したらジャンプ回数をリセット
            jumpCount = 0;
        }
    }
}
