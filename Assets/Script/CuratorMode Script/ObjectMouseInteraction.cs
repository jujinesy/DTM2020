using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMouseInteraction : MonoBehaviour
{

    float positionSpeed = 2.5f;
    float rotationSpeed = 5f;
    float scaleSpeed = 2.5f;


    private Transform tf_Player;//플레이어 위치 정보 받아오기
    //private GameObject gameObject1;

    //Raycast 필요변수 선언
    private RaycastHit hitInfo;
    [SerializeField]
    private LayerMask layerMask;
    [SerializeField]
    private float range;


    private Vector3 mOffset;
    private float mZCoord;

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Vector3 mousePoint = Input.mousePosition;

            float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
            gameObject.transform.Rotate(Vector3.down, XaxisRotation);

            float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
            gameObject.transform.Rotate(Vector3.up, YaxisRotation);

        }
    }






    void OnMouseDown()

    {

        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;



        // Store offset = gameobject world pos - mouse world pos

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();


    }





    private Vector3 GetMouseAsWorldPoint()

    {

        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;



        // z coordinate of game object on screen

        mousePoint.z = mZCoord;



        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }



    void OnMouseDrag()

    {

        transform.position = GetMouseAsWorldPoint() + mOffset;

    }

    private void PreviewPositionUpdate()
    {
        if (Physics.Raycast(tf_Player.position, tf_Player.forward, out hitInfo, range, layerMask)) //플레이어의 위치, 전방에쏜 레이저광선, 광선에 대한 정보를 hitInfo에 저장, 사정거리만큼 레이저 쏨, 레이어마스크에 걸리는게 있으면 부딪히게 만듦 
        {

            if (hitInfo.transform != null) //hitInfo.transform이 null이 아니면, hitInfo.point에 레이저를 쏴서 맞은 곳의 실제좌표 Venctor3를 반환; Preview의 포지션을 _location으로 반환
            {

                //Debug.Log("Hit info?" + hitInfo.);
                Vector3 _location = hitInfo.point;

                //Debug.Log("Raycast pos"+ _location);


                if (Input.GetKeyDown(KeyCode.Alpha1))
                    gameObject.transform.Rotate(0, -15f, 0f); //-15도로 회전
                if (Input.GetKeyDown(KeyCode.Alpha2))
                    gameObject.transform.Rotate(0, +15f, 0f); //+15도로 회전
                if (Input.GetKeyDown(KeyCode.Alpha3))
                    gameObject.transform.Rotate(-15f, 0f, 0f); //-15도로 회전
                if (Input.GetKeyDown(KeyCode.Alpha4))
                    gameObject.transform.Rotate(+15f, 0f, 0f); //+15도로 회전


                _location.Set(Mathf.Round(_location.x / 0.1f) * 0.1f, Mathf.Round(_location.y / 0.1f) * 0.1f, Mathf.Round(_location.z)); //Mathf.Round()정수형에 가깝게 반올림/내림 처리
                                                                                                                                         //y값의 경우 0.1단위로 이동됨

                gameObject.transform.position = _location; //Raycast의 위치에 설치되도록 설정




            }

        }
    }



    /*float positionSpeed = 2.5f;
    float rotationSpeed = 2.5f;
    float scaleSpeed = 2.5f;

    // Start is called before the first frame update
    private void OnMouseDrag()
    {

        Time.timeScale = 0f;
        float XaxisRotation = Input.GetAxis("Mouse X") * positionSpeed;
        transform.Rotate(Vector3.down, XaxisRotation);

        float XaxisPosition = Input.GetAxis("Mouse ScrollWheel") * positionSpeed;
        this.transform.position = this.transform.position + new Vector3(1, 1, 0);

        float XaxisScale = Input.GetAxis("Mouse Y") * scaleSpeed;
        transform.localScale = transform.localScale + new Vector3(1, 0, 0);

        float YaxisScale = Input.GetAxis("RightV") * scaleSpeed;
        transform.localScale = transform.localScale + new Vector3(0, 1, 0);



        Time.timeScale = 1f;

    }*/

}
