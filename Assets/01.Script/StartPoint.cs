using Unity.VisualScripting;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    public Transform startPoint; // 
    
    void Start()
    {
        transform.position = startPoint.position; // 캐릭터의 위치를 시작점 오브젝트 위치로 설정
    }

    
    void Update()
    {
        
    }
}
