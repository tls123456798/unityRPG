using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string transferMapName; // �̵��� ���� �̸�

    
    void Start()
    {
       
    }

    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene(transferMapName);
        }
    }
}
