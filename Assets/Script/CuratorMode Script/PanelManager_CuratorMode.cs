using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;

public class PanelManager_CuratorMode : MonoBehaviour

{
    public Camera MainCamera;
    public GameObject MuseumPortfolioPanel;
    public GameObject CataloguePanel; 
    public GameObject ArtworkPanel; //Museum Portfolio > 각 작품에 대한 설명을 저작하는 2D UI
    public GameObject ArtworkDetailPanel; //3D Museum > 각 작품 클릭시 등장하는 해당 작품에 대한 설명 2D UI
    public GameObject MyCurationPanel; //3D Museum > 하단 3D 작품 및 패널 quick slot 메뉴
    public GameObject CollectionPanel;
    public GameObject ArtworkDetailViewPanel;
    public GameObject SaveAsPanel;

    //spacetelling panels
    public GameObject wall1_slot;
    public GameObject wall2_slot;
    public GameObject wall3_slot;
    public GameObject wall4_slot;
    public GameObject wall5_slot;
    public GameObject wall6_slot;
    public GameObject topview_pos_panel;


    public GameObject LowerMenuPanel;
    public GameObject PauseMenuPanel;


    public void OpenMuseumPortfolioPanel()
    {

        if (MuseumPortfolioPanel != null)
        {
            bool isActive = MuseumPortfolioPanel.activeSelf;
            MuseumPortfolioPanel.SetActive(!isActive);
            LowerMenuPanel.SetActive(false);
            PauseMenuPanel.SetActive(false);
            ArtworkPanel.SetActive(false);
        }

    }
    public void OpenCataloguePanel()
    {
        if (CataloguePanel != null)
        {
            bool isActive = CataloguePanel.activeSelf;
            CataloguePanel.SetActive(!isActive);
            LowerMenuPanel.SetActive(false);
            PauseMenuPanel.SetActive(false);
            ArtworkPanel.SetActive(false);  
            CollectionPanel.SetActive(false);
            wall1_slot.SetActive(false);
            wall2_slot.SetActive(false);
            wall3_slot.SetActive(false);
            wall4_slot.SetActive(false);
            wall5_slot.SetActive(false);
            wall6_slot.SetActive(false);
            topview_pos_panel.SetActive(false);


        }

    }    
    
    public void OpenCollectionPanel()
    {
        if (CollectionPanel != null)
        {
            bool isActive = CollectionPanel.activeSelf;
            CollectionPanel.SetActive(!isActive);
            LowerMenuPanel.SetActive(false);
            PauseMenuPanel.SetActive(false);
            ArtworkPanel.SetActive(false);  
            MyCurationPanel.SetActive(false);  
            CataloguePanel.SetActive(false);
            wall1_slot.SetActive(false);
            wall2_slot.SetActive(false);
            wall3_slot.SetActive(false);
            wall4_slot.SetActive(false);
            wall5_slot.SetActive(false);
            wall6_slot.SetActive(false);
            topview_pos_panel.SetActive(false);


        }

    }
    public void OpenArtworkPanel(int num)
    {
        GameObject.Find("Canvas").transform.FindChild("menuUI").gameObject.transform.FindChild("MuseumCatalogue_Panel").gameObject.transform.FindChild("artwork_Panel").gameObject.transform.FindChild("bg_Panel").gameObject.transform.FindChild("Panel").gameObject.transform.FindChild("artwork_3dPanel_1").gameObject.transform.FindChild("des").GetComponent<InputField>().text = "";
        GameObject.Find("Canvas").transform.FindChild("menuUI/MuseumCatalogue_Panel/artwork_Panel/bg_Panel/Panel/artwork_3dPanel_2/des").GetComponent<InputField>().text = "";
        GameObject.Find("Canvas").transform.FindChild("menuUI/MuseumCatalogue_Panel/artwork_Panel/bg_Panel/Panel/artwork_3dPanel_3/des").GetComponent<InputField>().text = "";


        List<Img_SavaData> img_SaveData_Curator = new List<Img_SavaData>();
        GameManager_Curator.Instance.iOpenArtworkPanel_num = num;

        byte[] decodedBytes = Convert.FromBase64String(GameManager_Curator.Instance.img_info_load);
        string decodedText = Encoding.UTF8.GetString(decodedBytes);
        Img_SavaDataList imglist = JsonUtility.FromJson<Img_SavaDataList>(decodedText);
        img_SaveData_Curator = imglist.list;

        foreach (Img_SavaData isd in img_SaveData_Curator)
        {
            if (isd.idx != GameManager_Curator.Instance.iOpenArtworkPanel_num)
                continue;
            GameObject.Find("Canvas").transform.FindChild("menuUI").gameObject.transform.FindChild("MuseumCatalogue_Panel").gameObject.transform.FindChild("artwork_Panel").gameObject.transform.FindChild("bg_Panel").gameObject.transform.FindChild("Panel").gameObject.transform.FindChild("artwork_3dPanel_1").gameObject.transform.FindChild("des").GetComponent<InputField>().text = isd.Panel_1_des;
            GameObject.Find("Canvas").transform.FindChild("menuUI/MuseumCatalogue_Panel/artwork_Panel/bg_Panel/Panel/artwork_3dPanel_2/des").GetComponent<InputField>().text = isd.Panel_2_des;
            GameObject.Find("Canvas").transform.FindChild("menuUI/MuseumCatalogue_Panel/artwork_Panel/bg_Panel/Panel/artwork_3dPanel_3/des").GetComponent<InputField>().text = isd.Panel_3_des;
        }

        if (ArtworkPanel != null)
        {
            bool isActive = ArtworkPanel.activeSelf;
            ArtworkPanel.SetActive(!isActive);
            LowerMenuPanel.SetActive(false);
            PauseMenuPanel.SetActive(false);
            CollectionPanel.SetActive(false);
            wall1_slot.SetActive(false);
            wall2_slot.SetActive(false);
            wall3_slot.SetActive(false);
            wall4_slot.SetActive(false);
            wall5_slot.SetActive(false);
            wall6_slot.SetActive(false);
            topview_pos_panel.SetActive(false);

        }

    }
    public void OpenArtworkDetailPanel()
    {
        if (ArtworkDetailPanel != null)
        {
            bool isActive = ArtworkDetailPanel.activeSelf;
            ArtworkDetailPanel.SetActive(!isActive);
            LowerMenuPanel.SetActive(false);
            PauseMenuPanel.SetActive(false);


        }

    }    


    public void OpenLowerMenuPanel()
    {
     
        if (LowerMenuPanel != null)
        {
            bool isActive = LowerMenuPanel.activeSelf;
            LowerMenuPanel.SetActive(!isActive);
            MuseumPortfolioPanel.SetActive(false);
            PauseMenuPanel.SetActive(false);
            ArtworkPanel.SetActive(false);
        }
    }

    public void OpenArtworkDetailViewPanel()
    {
        if (ArtworkDetailViewPanel != null)
        {
            bool isActive = ArtworkDetailViewPanel.activeSelf;
            ArtworkDetailViewPanel.SetActive(!isActive);
            PauseMenuPanel.SetActive(false);
        }
    }


    public void OpenMyCurationPanel()
    {
        if (MyCurationPanel != null)
        {
            bool isActive = MyCurationPanel.activeSelf;
            MyCurationPanel.SetActive(!isActive);
            MainCamera.enabled = true;
            wall1_slot.SetActive(false);
            wall2_slot.SetActive(false);
            wall3_slot.SetActive(false);
            wall4_slot.SetActive(false);
            wall5_slot.SetActive(false);
            wall6_slot.SetActive(false);
            topview_pos_panel.SetActive(false);
        }

    }

    public void OpenWall1Slot()
    {
        if (wall1_slot != null)
        {
            bool isActive = wall1_slot.activeSelf;
            wall1_slot.SetActive(!isActive);
            wall2_slot.SetActive(false);
            wall3_slot.SetActive(false);
            wall4_slot.SetActive(false);
            wall5_slot.SetActive(false);
            wall6_slot.SetActive(false);
            topview_pos_panel.SetActive(false);
            CataloguePanel.SetActive(false);
            ArtworkPanel.SetActive(false);
            ArtworkDetailPanel.SetActive(false);
            CollectionPanel.SetActive(false);
            ArtworkDetailViewPanel.SetActive(false);


        }
    }
     public void OpenWall2Slot()
    {

        if (wall2_slot != null)
        {
            bool isActive = wall2_slot.activeSelf;
            wall2_slot.SetActive(!isActive);
            wall1_slot.SetActive(false);
            wall3_slot.SetActive(false);
            wall4_slot.SetActive(false);
            wall5_slot.SetActive(false);
            wall6_slot.SetActive(false);
            topview_pos_panel.SetActive(false);
            CataloguePanel.SetActive(false);
            ArtworkPanel.SetActive(false);
            ArtworkDetailPanel.SetActive(false);
            CollectionPanel.SetActive(false);
            ArtworkDetailViewPanel.SetActive(false);


        }
    }
     public void OpenWall3Slot()
    {
        if (wall3_slot != null)
        {
            bool isActive = wall3_slot.activeSelf;
            wall3_slot.SetActive(!isActive);
            wall1_slot.SetActive(false);
            wall2_slot.SetActive(false);
            wall4_slot.SetActive(false);
            wall5_slot.SetActive(false);
            wall6_slot.SetActive(false);
            topview_pos_panel.SetActive(false);
            CataloguePanel.SetActive(false);
            ArtworkPanel.SetActive(false);
            ArtworkDetailPanel.SetActive(false);
            CollectionPanel.SetActive(false);
            ArtworkDetailViewPanel.SetActive(false);

        }
    }
     public void OpenWall4Slot()
    {
        if (wall4_slot != null)
        {
            bool isActive = wall4_slot.activeSelf;
            wall4_slot.SetActive(!isActive);
            wall1_slot.SetActive(false);
            wall2_slot.SetActive(false);
            wall3_slot.SetActive(false);
            wall5_slot.SetActive(false);
            wall6_slot.SetActive(false);
            topview_pos_panel.SetActive(false);
            CataloguePanel.SetActive(false);
            ArtworkPanel.SetActive(false);
            ArtworkDetailPanel.SetActive(false);
            CollectionPanel.SetActive(false);
            ArtworkDetailViewPanel.SetActive(false);



            //MuseumPortfolioPanel.SetActive(false);
            //PauseMenuPanel.SetActive(false);
            //ArtworkPanel.SetActive(false);
        }
    }
     public void OpenWall5Slot()
    {
        if (wall5_slot != null)
        {
            bool isActive = wall5_slot.activeSelf;
            wall5_slot.SetActive(!isActive);
            wall1_slot.SetActive(false);
            wall2_slot.SetActive(false);
            wall3_slot.SetActive(false);
            wall4_slot.SetActive(false);
            wall6_slot.SetActive(false);
            topview_pos_panel.SetActive(false);
            CataloguePanel.SetActive(false);
            ArtworkPanel.SetActive(false);
            ArtworkDetailPanel.SetActive(false);
            CollectionPanel.SetActive(false);
            ArtworkDetailViewPanel.SetActive(false);


            //MuseumPortfolioPanel.SetActive(false);
            //PauseMenuPanel.SetActive(false);
            //ArtworkPanel.SetActive(false);
        }
    }
     public void OpenWall6Slot()
    {

        if (wall6_slot != null)
        {
            bool isActive = wall6_slot.activeSelf;
            wall6_slot.SetActive(!isActive);
            wall1_slot.SetActive(false);
            wall2_slot.SetActive(false);
            wall3_slot.SetActive(false);
            wall4_slot.SetActive(false);
            wall5_slot.SetActive(false);
            topview_pos_panel.SetActive(false);
            CataloguePanel.SetActive(false);
            ArtworkPanel.SetActive(false);
            ArtworkDetailPanel.SetActive(false);
            CollectionPanel.SetActive(false);
            ArtworkDetailViewPanel.SetActive(false);


        }
    }

    public void OpenTopViewPosPanel()
    {
        if (topview_pos_panel != null)
        {
            bool isActive = topview_pos_panel.activeSelf;
            topview_pos_panel.SetActive(!isActive);
            wall1_slot.SetActive(false);
            wall2_slot.SetActive(false);
            wall3_slot.SetActive(false);
            wall4_slot.SetActive(false);
            wall5_slot.SetActive(false);
            wall6_slot.SetActive(false);
            CataloguePanel.SetActive(false);
            ArtworkPanel.SetActive(false);
            ArtworkDetailPanel.SetActive(false);
            CollectionPanel.SetActive(false);
            ArtworkDetailViewPanel.SetActive(false);



        }
    }

    public void OpenPauseMenuPanel()
    {
        if (PauseMenuPanel != null)
        {
            bool isActive = PauseMenuPanel.activeSelf;
            PauseMenuPanel.SetActive(!isActive);
            LowerMenuPanel.SetActive(false);
       
        }
    }    
    
    public void OpenSaveAsPanel()
    {
        if (SaveAsPanel != null)
        {
            bool isActive = SaveAsPanel.activeSelf;
            SaveAsPanel.SetActive(!isActive);

        }
    }


    //ㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇ
    public void OpenTextPanel(GameObject go) 
    {
        
        UnityEngine.Debug.Log(go.transform.FindChild("des").GetComponent<InputField>().text);
        UnityEngine.Debug.Log(go.transform.FindChild("addQS_btn").gameObject.transform.FindChild("Toggle").GetComponent<Toggle>().isOn);


        GameObject obj = Instantiate(Resources.Load("3DPanel_1"), GameManager_Curator.Instance.tf_Player.position + GameManager_Curator.Instance.tf_Player.forward, Quaternion.identity) as GameObject;
        //obj.transform.position = osd.Pos;
        //obj.transform.eulerAngles = osd.Rot;
        //obj.transform.localScale = osd.Scale;
        obj.tag = "Newobjs";
        obj.transform.FindChild("3DPanel_1_text").gameObject.GetComponent<TextMesh>().text = go.transform.FindChild("des").GetComponent<InputField>().text;
        //UnityEngine.Debug.Log(GameManager_Curator.Instance.tf_Player.position);
        //GameManager.Instance.
        //Debug.Log(tg.isOn);
        //addQS_btn
    }

    public void OpenPanelinmain(GameObject go)
    {


        GameObject obj = Instantiate(Resources.Load("1_artwork"), GameManager_Curator.Instance.tf_Player.position + GameManager_Curator.Instance.tf_Player.forward, Quaternion.identity) as GameObject;
        obj.tag = "Newobjs";
    }
    //ㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇㅇ

}
