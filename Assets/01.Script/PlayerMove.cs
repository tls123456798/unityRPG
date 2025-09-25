using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D playerRigidbody2D; // �̵��� ���� ������ٵ� ������Ʈ
    public float speed = 4f; // �̵� �ӵ�

   
    void Start()
    {
        // ���� ������Ʈ���� Rigidbody2D ������Ʈ�� ã�� playerRigidbody2D�� �Ҵ�
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        // ������� ������ �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        // ���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ���� ����
        float xSpeed = xInput * speed;
        float ySpeed = yInput * speed;

        // Vector2 �ӵ��� (xSpeed, ySpeed) �� ����
        Vector2 newVelocity = new Vector2(xSpeed, ySpeed);
        // ������ٵ��� �ӵ��� newVelocity �Ҵ�
        playerRigidbody2D.linearVelocity = newVelocity;
    }
}
