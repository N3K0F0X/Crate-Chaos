
using UnityEngine;
public class GameOver : MonoBehaviour
{


    void Start()
    {
        
    }
    void Update()
    {
        GameObject[] Objects;
        Objects = GameObject.FindGameObjectsWithTag("Object");
        
        if (Objects.Length > 50)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver!");
        }
    }
}
