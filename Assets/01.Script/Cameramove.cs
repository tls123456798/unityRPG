using UnityEngine;

public class Cameramove : MonoBehaviour
{
    public Transform player; // �÷��̾��� Transform�� �Ҵ��մϴ�
    [SerializeField] float smoothing = 0.5f; // ī�޶� ���� ���� �ε巯�� ����
    void LateUpdate()
    {
        // ī�޶��� ��ġ�� �÷��̾��� ��ġ�� �̵��մϴ�
        Vector3 newPosition = player.position;
        // ���� ī�޶��� z�� ��ġ�� �����մϴ�
        newPosition.z = transform.position.z;

        // �ε巯�� �������� ���� Lerp �� ����մϴ�
        transform.position = Vector3.Lerp(transform.position, newPosition, smoothing);
    }

    
    void Update()
    {
        
    }
}
