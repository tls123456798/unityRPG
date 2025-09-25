using UnityEngine;

public class Cameramove : MonoBehaviour
{
    public Transform player; // 플레이어의 Transform을 할당합니다
    [SerializeField] float smoothing = 0.5f; // 카메라가 따라갈 때으 부드러움 정도
    void LateUpdate()
    {
        // 카메라의 위치를 플레이어의 위치로 이동합니다
        Vector3 newPosition = player.position;
        // 현재 카메라의 z축 위치를 유지합니다
        newPosition.z = transform.position.z;

        // 부드러운 움직임을 위해 Lerp 를 사용합니다
        transform.position = Vector3.Lerp(transform.position, newPosition, smoothing);
    }

    
    void Update()
    {
        
    }
}
