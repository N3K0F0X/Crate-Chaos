using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenuButtons : MonoBehaviour
{
    public GameObject Camerapos;
    public GameObject MainCam;


    public void CameraMovement()
    {
        MainCam.transform.position = Camerapos.transform.position;
        MainCam.transform.rotation = Camerapos.transform.rotation;
    }

    public void ButtonThatLetsYouQuit()
    {
        Application.Quit();
    }


}