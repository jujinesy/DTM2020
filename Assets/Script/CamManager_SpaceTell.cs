using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager_SpaceTell : MonoBehaviour { 

    public Camera[] cams;


    public void Start()
    {
        cams[0].enabled = true;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = false;
        cams[5].enabled = false;
        cams[6].enabled = false;
        cams[7].enabled = false; //top view camera
    }

    public void MainCam() //cams[0] = 플레이어 MainCamera
    {


        cams[0].enabled = true; //main camera
        cams[1].enabled = false; 
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = false;
        cams[5].enabled = false;
        cams[6].enabled = false;
        cams[7].enabled = false; //top view camera



    }

    public void camWall1()
    {

        cams[0].enabled = false; //cams[0] = 플레이어 MainCamera
        cams[1].enabled = true;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = false;
        cams[5].enabled = false;
        cams[6].enabled = false;
        cams[7].enabled = false;


    }
    public void camWall2()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = true;
        cams[3].enabled = false;
        cams[4].enabled = false;
        cams[5].enabled = false;
        cams[6].enabled = false;
        cams[7].enabled = false;



    }
    public void camWall3()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = true;
        cams[4].enabled = false;
        cams[5].enabled = false;
        cams[6].enabled = false;
        cams[7].enabled = false;


    }
    public void camWall4()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = true;
        cams[5].enabled = false;
        cams[6].enabled = false;
        cams[7].enabled = false;


    }
    public void camWall5()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = false;
        cams[5].enabled = true;
        cams[6].enabled = false;
        cams[7].enabled = false;



    }
    public void camWall6()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = false;
        cams[5].enabled = false;
        cams[6].enabled = true;
        cams[7].enabled = false;


    }
    public void OpentopViewPosPanel()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = false;
        cams[5].enabled = false;
        cams[6].enabled = false;
        cams[7].enabled = true;



    }


}
