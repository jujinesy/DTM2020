using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Reflection;
using System;
using UnityEngine.SceneManagement;

public class ButtonListButton : MonoBehaviour
{
    public Text tnum;
    public Text ttitle;
    public Text ttime;
    public SVManager svm;

    public string num;

    // Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}


    public void Setfiled(string textString, string title, string time)
    {
        //Debug.Log(textString);
        num = textString;
        tnum.text = textString;
        ttitle.text = title;
        ttime.text = time;
    }

    public void OnClick()
    {
        //Debug.Log(myTextString);
        int i = Convert.ToInt32(num);
        i--;
        svm.ButtonClicked(num);

        GameManager.Instance.isload = true;
        GameManager.Instance.obj_info = GameManager.Instance.loadData[i].obj_info;
        GameManager.Instance.img_info = GameManager.Instance.loadData[i].img_info;

        SceneManager.LoadScene("CuratorMode");
        //GameManager.Instance.img_info = 

    }


}
