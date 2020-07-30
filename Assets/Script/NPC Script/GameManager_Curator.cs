using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_Curator : MonoBehaviour
{

    // 싱글톤 패턴을 사용하기 위한 인스턴스 변수
    private static GameManager_Curator _instance;
    // 인스턴스에 접근하기 위한 프로퍼티
    public static GameManager_Curator Instance
    {
        get
        {
            // 인스턴스가 없는 경우에 접근하려 하면 인스턴스를 할당해준다.
            if (!_instance)
            {
                _instance = FindObjectOfType(typeof(GameManager_Curator)) as GameManager_Curator;

                if (_instance == null)
                    Debug.Log("no Singleton obj");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        // 인스턴스가 존재하는 경우 새로생기는 인스턴스를 삭제한다.
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
        // 아래의 함수를 사용하여 씬이 전환되더라도 선언되었던 인스턴스가 파괴되지 않는다.
        //DontDestroyOnLoad(gameObject);
    }


    public static bool canPlayerMove = true; //플레이어 움직임 제어; 시작부터 움직일 수 있어야하므로 true;
    public static bool isOpenMenu = false; //인벤토리 활성화 여부
    public static bool isOpenCraftManual = false; //건축 메뉴 활성화 여부 

    public static bool isPause = false; //메뉴 호출시 true됨

    //메뉴 UI 호출
    private bool isActivated = false; //닫힌 상태로 시작하므로 기본값은 false

    [SerializeField]
    private GameObject go_BaseUI=null; // 기본 베이스 ui
    public Transform tf_Player;




    public List<Craft> obj_Craft = new List<Craft>();

    public int iOpenArtworkPanel_num;
    public string img_info_load;



    // Start is called before the first frame update
    void Start()
    {
        //시작 화면
        //Cursor.lockState = CursorLockMode.Locked; //커서를 가운데에 고정시켜 잠그기
        //Cursor.visible = false; //커서 안보이게 만들기

        if (GameObject.Find("UserInfo") != null)
            if(GameManager.Instance != null)
            GameObject.Find("UserInfo").GetComponent<Text>().text = GameManager.Instance.user_name + " " + GameManager.Instance.user_org_pos + "님\n saved time: 0000.00.00 00:00";

        //if (GameObject.Find("UserInfo2") != null)
        //    GameObject.Find("UserInfo2").GetComponent<Text>().text = GameManager.Instance.user_name + " " + GameManager.Instance.user_org_pos + "'s collection";
        if (GameManager.Instance != null)
            if (GameManager.Instance.isload)
            {
                SaveLoad sv = new SaveLoad();
                sv.StartLoadData();
            }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) // && !isPreviewActivated) //으로 처리하면 중복 생성 방지가능 
        {
            Window();

            /*if (isOpenInventory || isOpenCraftManual || isPause) //n개 중 하나 조건 충족시
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                canPlayerMove = false;
            }

            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                canPlayerMove = true;
            }
            */
        }
    }




    private void Window()
    {
        if (!isActivated)
            OpenWindow();
        else
            CloseWindow();

    }

    private void OpenWindow()
    {
        isActivated = true;
        go_BaseUI.SetActive(true);


    }
    private void CloseWindow()
    {
        isActivated = false;
        go_BaseUI.SetActive(false);
    }
}

