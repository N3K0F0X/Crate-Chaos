using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToMainmenu : MonoBehaviour
{
    public void ReturnToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }
}
