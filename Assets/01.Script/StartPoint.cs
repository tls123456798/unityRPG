using Unity.VisualScripting;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    public Transform startPoint; // 
    
    void Start()
    {
        transform.position = startPoint.position; // ĳ������ ��ġ�� ������ ������Ʈ ��ġ�� ����
    }

    
    void Update()
    {
        
    }
}
