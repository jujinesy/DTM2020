using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using UnityEngine;

public class SVManager : MonoBehaviour
{

    //public Button itemButton;
    //public Text itemText;
    //public List<Item> Items { get; set; }

    //[SerializeField]
    public GameObject buttonTemplate;

    // Start is called before the first frame update
    void Start()
    {
        //gensv();
    }

    // Update is called once per frame
    void Update()
    {
        //gensv();
    }


    //public void ShowItems()
    //{
    //    ClearItems(); //Destroys button and text gameObjects.

    //    foreach (var item in Items)
    //    {
    //        var text = Instantiate(itemText) as Text;
    //        var button = Instantiate(itemButton) as Button;
    //        button.GetComponentInChildren<Text>().text = "Delete";
    //        textsList.Add(text); //save Text element to list to have possibility of destroying Text gameObjects
    //        buttonsList.Add(button);//save Button element to list to have possibility of destroying Button gameObjects
    //        text.gameObject.SetActive(true);
    //        button.gameObject.SetActive(true);
    //        //(...) Setting GUI items position here
    //    }
    //}

    //public void Init()
    //{
    //    int yValue = 0;
    //    for(int i = 0; i< 10; i++)
    //    {
    //        var index = Instantiate( , new Vector3(0, yValue, 0), Quaternion.identity);
    //        index.transform.SetParent(GameObject.Find("Content").transform);
    //        yValue -= 200;
    //    }
    //}

    public void gensv()
    {
        int i = 1;
        //buttons = new List<GameObject>();

        if (GameManager.Instance.btnload.Count > 0)
        {
            foreach (GameObject button in GameManager.Instance.btnload)
            {
                Destroy(button.gameObject);
            }
            GameManager.Instance.btnload.Clear();
        }

        foreach (LoadData ld in GameManager.Instance.loadData)
        {
            GameObject button = Instantiate(buttonTemplate) as GameObject;
            button.SetActive(true);
            button.GetComponent<ButtonListButton>().Setfiled(Convert.ToString(i++), ld.save_title, ld.create_time);
            button.transform.SetParent(buttonTemplate.transform.parent, false);
            GameManager.Instance.btnload.Add(button);
        }


    }

    public void ButtonClicked(string myTextString)
    {
        Debug.Log(myTextString);
    }

}
