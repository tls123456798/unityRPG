using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    int curIdx = 0;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            curIdx = SceneManager.GetActiveScene().buildIndex;
            print(curIdx);
            if (curIdx < 1)
            {
                SceneManager.LoadScene(++curIdx);
            }
        }  
     }
 }