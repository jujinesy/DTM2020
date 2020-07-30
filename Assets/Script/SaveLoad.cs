using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
//using System.Diagnostics;
using System;
using System.Text;
using UnityEngine.UI;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
//input output data출력



//정보 직렬화
[System.Serializable]
public class Obj_SavaData
{
    //public Vector3 playerPos;
    //public Vector3 playerRot; //플레이어 뷰잉 각도 저장
    //public Vector3 gameObjectPos; 
    //public Vector3 gameObjectRot; 
    public string name;
    public Vector3 Pos;
    public Vector3 Rot;
    public Vector3 Scale;
}

[System.Serializable]
public class Obj_SavaDataList
{
    public List<Obj_SavaData> list;
}

[System.Serializable]
public class Img_SavaData
{
    public int idx;

    public string Panel_1_des;
    public string Panel_2_des;
    public string Panel_3_des;
    //public string artwork_media;
    //public string artwork_title;
    //public string artwork_year;
    //public string artwork_media_detail;
    //public string artwork_artist;
    //public string artwork_artist_year;
    //public string artwork_region;
    //public string artwork_size;
    //public string artwork_frame_size;
    //public string artwork_myIdea;
    //public string artwork_des;
    //public string artwork_des_detail;
    //public string artwork_artist_des;
    //public string artwork_artist_des_detail;
}

[System.Serializable]
public class Img_SavaDataList
{
    public List<Img_SavaData> list;
}


[System.Serializable]
public class LoadData
{
    public string idx;
    public string save_title;
    public string obj_info;
    public string img_info;
    public string create_time;
    //public string artwork_media;
    //public string artwork_title;
    //public string artwork_year;
    //public string artwork_media_detail;
    //public string artwork_artist;
    //public string artwork_artist_year;
    //public string artwork_region;
    //public string artwork_size;
    //public string artwork_frame_size;
    //public string artwork_myIdea;
    //public string artwork_des;
    //public string artwork_des_detail;
    //public string artwork_artist_des;
    //public string artwork_artist_des_detail;
}

[System.Serializable]
public class LoadDataList
{
    public List<LoadData> list;
}






//public static class JsonHelper
//{
//    public static T[] FromJson<T>(string json)
//    {
//        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
//        return wrapper.items;
//    }
//    public static string ToJson<T>(T[] array)
//    {
//        Wrapper<T> wrapper = new Wrapper<T>();
//        wrapper.items = array;
//        return JsonUtility.ToJson(wrapper);
//    }

//    public static string ToJson<T>(T[] array, bool prettyPrint)
//    {
//        Wrapper<T> wrapper = new Wrapper<T>();
//        wrapper.items = array;
//        return JsonUtility.ToJson(wrapper, prettyPrint);
//    }

//    [System.Serializable]
//    private class Wrapper<T>
//    {
//        public T[] items;
//    }
//}

public static class JsonHelper
{
    public static T[] FromJson<T>(string json)
    {
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
        return wrapper.items;
    }
    public static string ToJson<T>(T[] array)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.items = array;
        return JsonUtility.ToJson(wrapper);
    }

    public static string ToJson<T>(T[] array, bool prettyPrint)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.items = array;
        return JsonUtility.ToJson(wrapper, prettyPrint);
    }
    
    [System.Serializable]
    private class Wrapper<T>
    {
        public T[] items;
    }
}



public class SaveLoad : MonoBehaviour
{

    private List<Obj_SavaData> obj_SaveData = new List<Obj_SavaData>();
    private List<Img_SavaData> img_SaveData = new List<Img_SavaData>();

    //    private string SAVE_DATA_DIRECTORY;
    //    private string SAVE_FILENAME = "/SaveFile.txt/";

    //private PlayerController thePlayer;
    //private CraftManual theGameObject;


    // Start is called before the first frame update
    void Start()
    {
        //GameObject obj = Instantiate(Resources.Load("floor", typeof(GameObject))) as GameObject;
        //obj.transform.position = new Vector3(-5.987377f, 1.075586f, -0.845927f);
        //obj.transform.localScale = new Vector3(500f, 500f, 500f);
        //        SAVE_DATA_DIRECTORY = Application.dataPath + "/Saves/"; //게임 프로젝트가 담겨있는 폴더, 즉 Asset 폴더 + Save폴더 디렉토리 생성하여 여기에 저장
        //if (!Directory.Exists(Application.dataPath + "/Saves/"))
            //using System.IO; 입력후 디렉토리 생성; 해당 디렉토리가 있는지 여부 확인
            //Directory.CreateDirectory(Application.dataPath + "/Saves/"); //디렉토리가 없을 경우 자동으로 /Saves/에 생성
        Debug.Log("SaveLoad_Start");
    }



    public void SaveData()
    {
        obj_SaveData.Clear();
        img_SaveData.Clear();
        //Debug.Log("SaveLoad_SaveData");
        //thePlayer = FindObjectOfType<PlayerController>(); //플레이어 위치 발견
        //saveData.playerPos = thePlayer.transform.position;
        //saveData.playerRot = thePlayer.transform.eulerAngles; // rotation의 Vector3 값을 호출하는것이므로 eulerAngles

        //theGameObject = FindObjectOfType<CraftManual>();
        //saveData.gameObjectPos = theGameObject.transform.position;
        //saveData.gameObjectRot = theGameObject.transform.eulerAngles;

        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Newobjs"))
        {
            Obj_SavaData temp = new Obj_SavaData();
            temp.name = fooObj.name;
            temp.Pos = fooObj.transform.position;
            temp.Rot = fooObj.transform.eulerAngles;
            temp.Scale = fooObj.transform.localScale;
            obj_SaveData.Add(temp);
            //Debug.Log(fooObj.transform.position);
            //Debug.Log(fooObj.transform.eulerAngles);
            //Debug.Log(fooObj.name);
            //Do Something
        }
        Obj_SavaDataList objlist = new Obj_SavaDataList();
        objlist.list = obj_SaveData;

        string json = JsonUtility.ToJson(objlist); //파일을 물리적으로 이동; Json Utility중 JSON으로 바꾸는것 활용, player의 위치를 json화

        byte[] bytesToEncode = Encoding.UTF8.GetBytes(json);
        string obj_encodedText = Convert.ToBase64String(bytesToEncode);
        //File.WriteAllText(Application.dataPath + "/Saves/SaveFile.txt", encodedText);


        string img_encodedText;
        if (GameObject.Find("Canvas").transform.FindChild("menuUI/MuseumCatalogue_Panel/artwork_Panel").gameObject.activeSelf)
        {
            Debug.Log("패널열림");

            List<Img_SavaData> img_SaveData_Curator = new List<Img_SavaData>();
            byte[] decodedBytes = Convert.FromBase64String(GameManager_Curator.Instance.img_info_load);
            string decodedText = Encoding.UTF8.GetString(decodedBytes);
            Img_SavaDataList imglist = JsonUtility.FromJson<Img_SavaDataList>(decodedText);
            img_SaveData_Curator = imglist.list;

            Img_SavaData temp2 = new Img_SavaData();
            foreach (Img_SavaData isd in img_SaveData_Curator)
            {
                if (isd.idx == GameManager_Curator.Instance.iOpenArtworkPanel_num)
                    continue;

                temp2 = new Img_SavaData();
                temp2.idx = isd.idx;
                temp2.Panel_1_des = isd.Panel_1_des;
                temp2.Panel_2_des = isd.Panel_2_des;
                temp2.Panel_3_des = isd.Panel_3_des;
                img_SaveData.Add(temp2);
            }

            temp2 = new Img_SavaData();
            temp2.idx = GameManager_Curator.Instance.iOpenArtworkPanel_num;
            temp2.Panel_1_des = GameObject.Find("Canvas").transform.FindChild("menuUI").gameObject.transform.FindChild("MuseumCatalogue_Panel").gameObject.transform.FindChild("artwork_Panel").gameObject.transform.FindChild("bg_Panel").gameObject.transform.FindChild("Panel").gameObject.transform.FindChild("artwork_3dPanel_1").gameObject.transform.FindChild("des").gameObject.transform.FindChild("Text").GetComponent<Text>().text;
            temp2.Panel_2_des = GameObject.Find("Canvas").transform.FindChild("menuUI/MuseumCatalogue_Panel/artwork_Panel/bg_Panel/Panel/artwork_3dPanel_2/des/Text").GetComponent<Text>().text;
            temp2.Panel_3_des = GameObject.Find("Canvas").transform.FindChild("menuUI/MuseumCatalogue_Panel/artwork_Panel/bg_Panel/Panel/artwork_3dPanel_3/des/Text").GetComponent<Text>().text;
            img_SaveData.Add(temp2);
            Img_SavaDataList imglist2 = new Img_SavaDataList();
            imglist2.list = img_SaveData;
            json = JsonUtility.ToJson(imglist2); //파일을 물리적으로 이동; Json Utility중 JSON으로 바꾸는것 활용, player의 위치를 json화
            bytesToEncode = Encoding.UTF8.GetBytes(json);
            img_encodedText = GameManager_Curator.Instance.img_info_load = Convert.ToBase64String(bytesToEncode);
        }
        else
        {
            Debug.Log("패널닫힘");
            img_encodedText = GameManager_Curator.Instance.img_info_load;
        }

        //Img_SavaData temp2 = new Img_SavaData();
        //temp2.idx = 1;
        //temp2.Panel_1_des = GameObject.Find("Canvas").transform.FindChild("menuUI").gameObject.transform.FindChild("MuseumCatalogue_Panel").gameObject.transform.FindChild("artwork_Panel").gameObject.transform.FindChild("bg_Panel").gameObject.transform.FindChild("Panel").gameObject.transform.FindChild("artwork_3dPanel_1").gameObject.transform.FindChild("des").gameObject.transform.FindChild("Text").GetComponent<Text>().text;
        //temp2.Panel_2_des = GameObject.Find("Canvas").transform.FindChild("menuUI/MuseumCatalogue_Panel/artwork_Panel/bg_Panel/Panel/artwork_3dPanel_2/des/Text").GetComponent<Text>().text;
        //temp2.Panel_3_des = GameObject.Find("Canvas").transform.FindChild("menuUI/MuseumCatalogue_Panel/artwork_Panel/bg_Panel/Panel/artwork_3dPanel_3/des/Text").GetComponent<Text>().text;
        //img_SaveData.Add(temp2);
        //Img_SavaDataList imglist = new Img_SavaDataList();
        //imglist.list = img_SaveData;
        //json = JsonUtility.ToJson(imglist); //파일을 물리적으로 이동; Json Utility중 JSON으로 바꾸는것 활용, player의 위치를 json화
        //bytesToEncode = Encoding.UTF8.GetBytes(json);
        //img_encodedText = Convert.ToBase64String(bytesToEncode);



        //Debug.Log(p1_des);

        string stitle = GameObject.Find("Canvas").transform.FindChild("menuUI").gameObject.transform.FindChild("save_btn/save_as_Panel/InputField").GetComponent<InputField>().text;
        //Debug.Log(stitle.Replace("\"","").Replace("\'",""));


        NetWWW.INSTANCE().UserSave(GameManager.Instance.user_email, stitle.Replace("\"", "").Replace("\'", ""), obj_encodedText, img_encodedText);

        Debug.Log("저장완료");
        Debug.Log(json);


    }

    public void LoadData()
    {
        //Debug.Log("SaveLoad_SaveData");
        obj_SaveData.Clear();
        img_SaveData.Clear();

        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Newobjs"))
        {
            Destroy(fooObj);
        }

        NetWWW.INSTANCE().UserLoad(GameManager.Instance.user_email);
        StartCoroutine(DLoadData());

        //if (File.Exists(Application.dataPath + "/Saves/SaveFile.txt"))
        //{
        //    string loadJson = File.ReadAllText(Application.dataPath + "/Saves/SaveFile.txt"); //strong loadJson을 만들어읽어올 파일 정보 담음
        //    NetWWW.INSTANCE().UserLoad(GameManager.Instance.user_email);
        //    //while (true)
        //    //{
        //    //    if (!GameManager.Instance.obj_info.Equals(""))
        //    //        break;
        //    //}
        //    byte[] decodedBytes = Convert.FromBase64String(loadJson);
        //    string decodedText = Encoding.UTF8.GetString(decodedBytes);
        //    SavaDataList l = JsonUtility.FromJson<SavaDataList>(decodedText);
        //    saveData = l.list;

        //    foreach (var sd in saveData)
        //    {
        //        //Debug.Log("name : " + sd.name);
        //        //Debug.Log("Pos : " + sd.Pos);
        //        //Debug.Log("Rot : " + sd.Rot);
        //        GameObject obj = Instantiate(Resources.Load("floor", typeof(GameObject))) as GameObject;
        //        obj.transform.position = sd.Pos;
        //        obj.transform.localScale = sd.Scale;
        //        obj.tag = "Newobjs";
        //    }
        //    //GameObject obj2 = Instantiate(Resources.Load("floor", typeof(GameObject))) as GameObject;
        //    //obj2.transform.position = new Vector3(-5.987377f, 1.075586f, -0.845927f);
        //    //obj2.transform.localScale = new Vector3(500f, 500f, 500f);


        //    //saveData = JsonUtility.FromJson<SavaData>(loadJson); //string으로 만들어진 loadJson을 json화하는 것
        //    //thePlayer = FindObjectOfType<PlayerController>();
        //    //thePlayer.transform.position = saveData.playerPos;

        //    Debug.Log("로드완료");
        //}
        //else
        //{
        //    Debug.Log("세이브 파일이 없습니다");
        //}
    }

    IEnumerator DLoadData()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        string obj_Json = GameManager.Instance.obj_info;
        GameManager.Instance.obj_info = "";

        byte[] decodedBytes = Convert.FromBase64String(obj_Json);
        string decodedText = Encoding.UTF8.GetString(decodedBytes);
        Obj_SavaDataList objlist = JsonUtility.FromJson<Obj_SavaDataList>(decodedText);
        obj_SaveData = objlist.list;

        foreach (Obj_SavaData osd in obj_SaveData)
        //foreach (var sd in saveData)
        {
            //Debug.Log("name : " + sd.name);
            //Debug.Log("Pos : " + sd.Pos);
            //Debug.Log("Rot : " + sd.Rot);
            GameObject obj = Instantiate(Resources.Load("floor", typeof(GameObject))) as GameObject;
            obj.transform.position = osd.Pos;
            obj.transform.eulerAngles = osd.Rot;
            obj.transform.localScale = osd.Scale;
            obj.tag = "Newobjs";
        }


        string img_Json = GameManager.Instance.img_info;
        GameManager.Instance.img_info = "";

        decodedBytes = Convert.FromBase64String(img_Json);
        decodedText = Encoding.UTF8.GetString(decodedBytes);
        Img_SavaDataList imglist = JsonUtility.FromJson<Img_SavaDataList>(decodedText);
        img_SaveData = imglist.list;

        foreach (Img_SavaData isd in img_SaveData)
        {
            //GameObject.Find("Canvas").transform.FindChild("menuUI").gameObject.transform.FindChild("MuseumCatalogue_Panel").gameObject.transform.FindChild("artwork_Panel").gameObject.transform.FindChild("bg_Panel").gameObject.transform.FindChild("artwork_3dPanels").gameObject.transform.FindChild("artwork_3dPanel_1").gameObject.transform.FindChild("des").GetComponent<InputField>().Select();
            GameObject.Find("Canvas").transform.FindChild("menuUI").gameObject.transform.FindChild("MuseumCatalogue_Panel").gameObject.transform.FindChild("artwork_Panel").gameObject.transform.FindChild("bg_Panel").gameObject.transform.FindChild("Panel").gameObject.transform.FindChild("artwork_3dPanel_1").gameObject.transform.FindChild("des").GetComponent<InputField>().text = isd.Panel_1_des;
            GameObject.Find("Canvas").transform.FindChild("menuUI/MuseumCatalogue_Panel/artwork_Panel/bg_Panel/Panel/artwork_3dPanel_2/des/Text").GetComponent<Text>().text = isd.Panel_2_des;
            GameObject.Find("Canvas").transform.FindChild("menuUI/MuseumCatalogue_Panel/artwork_Panel/bg_Panel/Panel/artwork_3dPanel_3/des/Text").GetComponent<Text>().text = isd.Panel_3_des;
            //Debug.Log(isd.Panel_1_des);
        }

    }





    public void StartLoadData()
    {
        //Debug.Log("SaveLoad_SaveData");
        obj_SaveData.Clear();
        img_SaveData.Clear();

        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Newobjs"))
        {
            Destroy(fooObj);
        }

        //NetWWW.INSTANCE().UserLoad(GameManager.Instance.user_email);
        //StartCoroutine(StartDLoadData());

        string obj_Json = GameManager.Instance.obj_info;
        GameManager.Instance.obj_info = "";

        byte[] decodedBytes = Convert.FromBase64String(obj_Json);
        string decodedText = Encoding.UTF8.GetString(decodedBytes);
        Obj_SavaDataList objlist = JsonUtility.FromJson<Obj_SavaDataList>(decodedText);
        obj_SaveData = objlist.list;

        foreach (Obj_SavaData osd in obj_SaveData)
        //foreach (var sd in saveData)
        {
            //Debug.Log("name : " + sd.name);
            //Debug.Log("Pos : " + sd.Pos);
            //Debug.Log("Rot : " + sd.Rot);
            GameObject obj = Instantiate(Resources.Load("floor", typeof(GameObject))) as GameObject;
            obj.transform.position = osd.Pos;
            obj.transform.eulerAngles = osd.Rot;
            obj.transform.localScale = osd.Scale;
            obj.tag = "Newobjs";
        }



        GameManager_Curator.Instance.img_info_load = GameManager.Instance.img_info;

        //string img_Json = GameManager.Instance.img_info;
        //GameManager.Instance.img_info = "";
        

        //decodedBytes = Convert.FromBase64String(img_Json);
        //decodedText = Encoding.UTF8.GetString(decodedBytes);
        //Img_SavaDataList imglist = JsonUtility.FromJson<Img_SavaDataList>(decodedText);
        //img_SaveData = imglist.list;

        //foreach (Img_SavaData isd in img_SaveData)
        //{
        //    //GameObject.Find("Canvas").transform.FindChild("menuUI").gameObject.transform.FindChild("MuseumCatalogue_Panel").gameObject.transform.FindChild("artwork_Panel").gameObject.transform.FindChild("bg_Panel").gameObject.transform.FindChild("artwork_3dPanels").gameObject.transform.FindChild("artwork_3dPanel_1").gameObject.transform.FindChild("des").GetComponent<InputField>().Select();
        //    GameObject.Find("Canvas").transform.FindChild("menuUI").gameObject.transform.FindChild("MuseumCatalogue_Panel").gameObject.transform.FindChild("artwork_Panel").gameObject.transform.FindChild("bg_Panel").gameObject.transform.FindChild("Panel").gameObject.transform.FindChild("artwork_3dPanel_1").gameObject.transform.FindChild("des").GetComponent<InputField>().text = isd.Panel_1_des;
        //    GameObject.Find("Canvas").transform.FindChild("menuUI/MuseumCatalogue_Panel/artwork_Panel/bg_Panel/Panel/artwork_3dPanel_2/des").GetComponent<InputField>().text = isd.Panel_2_des;
        //    GameObject.Find("Canvas").transform.FindChild("menuUI/MuseumCatalogue_Panel/artwork_Panel/bg_Panel/Panel/artwork_3dPanel_3/des").GetComponent<InputField>().text = isd.Panel_3_des;

        //    //Debug.Log(isd.Panel_1_des);
        //}
    }

    IEnumerator StartDLoadData()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        string obj_Json = GameManager.Instance.obj_info;
        GameManager.Instance.obj_info = "";

        byte[] decodedBytes = Convert.FromBase64String(obj_Json);
        string decodedText = Encoding.UTF8.GetString(decodedBytes);
        Obj_SavaDataList objlist = JsonUtility.FromJson<Obj_SavaDataList>(decodedText);
        obj_SaveData = objlist.list;

        foreach (Obj_SavaData osd in obj_SaveData)
        //foreach (var sd in saveData)
        {
            //Debug.Log("name : " + sd.name);
            //Debug.Log("Pos : " + sd.Pos);
            //Debug.Log("Rot : " + sd.Rot);
            GameObject obj = Instantiate(Resources.Load("floor", typeof(GameObject))) as GameObject;
            obj.transform.position = osd.Pos;
            obj.transform.eulerAngles = osd.Rot;
            obj.transform.localScale = osd.Scale;
            obj.tag = "Newobjs";
        }


        string img_Json = GameManager.Instance.img_info;
        GameManager.Instance.img_info = "";

        decodedBytes = Convert.FromBase64String(img_Json);
        decodedText = Encoding.UTF8.GetString(decodedBytes);
        Img_SavaDataList imglist = JsonUtility.FromJson<Img_SavaDataList>(decodedText);
        img_SaveData = imglist.list;

        foreach (Img_SavaData isd in img_SaveData)
        {
            //GameObject.Find("Canvas").transform.FindChild("menuUI").gameObject.transform.FindChild("MuseumCatalogue_Panel").gameObject.transform.FindChild("artwork_Panel").gameObject.transform.FindChild("bg_Panel").gameObject.transform.FindChild("artwork_3dPanels").gameObject.transform.FindChild("artwork_3dPanel_1").gameObject.transform.FindChild("des").GetComponent<InputField>().Select();
            GameObject.Find("Canvas").transform.FindChild("menuUI").gameObject.transform.FindChild("MuseumCatalogue_Panel").gameObject.transform.FindChild("artwork_Panel").gameObject.transform.FindChild("bg_Panel").gameObject.transform.FindChild("Panel").gameObject.transform.FindChild("artwork_3dPanel_1").gameObject.transform.FindChild("des").GetComponent<InputField>().text = isd.Panel_1_des;
            Debug.Log(isd.Panel_1_des);
        }

    }
}
