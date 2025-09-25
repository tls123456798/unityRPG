using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D playerRigidbody2D; // 이동에 사용될 리지드바디 컴포넌트
    public float speed = 4f; // 이동 속도

   
    void Start()
    {
        // 게임 오브젝트에서 Rigidbody2D 컴포넌트를 찾아 playerRigidbody2D에 할당
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        // 수평축과 수직축 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        // 실제 이동 속도를 입력값과 이동 속력을 통해 결정
        float xSpeed = xInput * speed;
        float ySpeed = yInput * speed;

        // Vector2 속도를 (xSpeed, ySpeed) 로 생성
        Vector2 newVelocity = new Vector2(xSpeed, ySpeed);
        // 리지드바디의 속도에 newVelocity 할당
        playerRigidbody2D.linearVelocity = newVelocity;
    }
}
