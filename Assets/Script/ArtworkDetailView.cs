using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ArtworkDetailView : MonoBehaviour
{ 

    public GameObject ArtworkDetailViewPanel;
    public GameObject ArtworkDetailView_3Dtext;
    public GameObject MuseumPortfolioPanel;
    public GameObject MyCurationPanel; //하단 quick slot 메뉴


    // Start is called before the first frame update

    void OnMouseOver()
    {
        if (ArtworkDetailView_3Dtext != null)
        {
            bool isActive = ArtworkDetailView_3Dtext.activeSelf;
            ArtworkDetailView_3Dtext.SetActive(!isActive);
            

        }
    }
    void OnMouseExit()
        {
            Debug.Log("bye");

        }
    void OnMouseUp()
    {
        if (ArtworkDetailViewPanel != null)
        {
            bool isActive = ArtworkDetailViewPanel.activeSelf;
            ArtworkDetailViewPanel.SetActive(!isActive);


        }
    }
}







