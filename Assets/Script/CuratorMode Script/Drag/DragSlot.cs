//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class DragSlot : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Specialized;

public class DragSlot : MonoBehaviour, IDropHandler
{
	public GameObject item
	{
		get
		{
			if (transform.childCount > 0)
			{
				return transform.GetChild(0).gameObject;
			}
			return null;
		}
	}

	#region IDropHandler implementation
	public void OnDrop(PointerEventData eventData)
	{
		//if (!item)
		//{
		//	DragHandeler.itemBeingDragged.transform.SetParent(transform);
		//	ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());
		//}
		//Debug.Log(eventData);
		if(transform.name.ToString().Equals("pos_wall1_1"))
        {
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(1.395f, 1.497f, -5.488f);
			obj.transform.eulerAngles = new Vector3(0f, 95.75301f, 0f);
			//obj.transform.localScale = new Vector3(31.3f, 40f, 5f);
			obj.tag = "Newobjs";
		}


		//Transform a = transform;
		//Debug.Log(transform.ToString());
		//Debug.Log(DragHandeler.itemBeingDragged.transform.name);
		//GameObject obj = Instantiate(Resources.Load("1_artwork", typeof(GameObject))) as GameObject;
		//obj.transform.position = new Vector3(1.395f, 1.497f, - 5.488f);
		//obj.transform.eulerAngles = new Vector3(0f, 95.75301f, 0f);
		//obj.transform.localScale = new Vector3(31.3f, 40f, 5f);
		//obj.tag = "Newobjs";


		if (transform.name.ToString().Equals("pos_wall1_2")) //작품번호_wall1_2_artwork
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(1.395f, 1.497f, -5.488f);
			obj.transform.eulerAngles = new Vector3(0f, 95.75301f, 0f);
			obj.tag = "Newobjs";
		}

		if (transform.name.ToString().Equals("pos_wall2_1")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.315f, 1.514f, -7.551f);
			obj.transform.eulerAngles = new Vector3(0f, -90f, 0f);
			obj.tag = "Newobjs";
		}
		
		if (transform.name.ToString().Equals("pos_wall2_2")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.315f, 1.288f, -6.342f);
			obj.transform.eulerAngles = new Vector3(0f, -90f, 0f);
			obj.tag = "Newobjs";
		}

				
		if (transform.name.ToString().Equals("pos_wall2_3")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.315f, 1.7443f, -5.85f);
			obj.transform.eulerAngles = new Vector3(0f, -90f, 0f);
			obj.tag = "Newobjs";
		}
					
		if (transform.name.ToString().Equals("pos_wall2_3")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.315f, 1.7443f, -5.85f);
			obj.transform.eulerAngles = new Vector3(0f, -90f, 0f);
			obj.tag = "Newobjs";
		}
					
		if (transform.name.ToString().Equals("pos_wall2_4")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.315f, 1.4903f, -4.889f);
			obj.transform.eulerAngles = new Vector3(0f, -90f, 0f);
			obj.tag = "Newobjs";
		}
					
		if (transform.name.ToString().Equals("pos_wall2_5")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.32f, 1.452f, -3.995f);
			obj.transform.eulerAngles = new Vector3(0f, -90f, 0f);
			obj.tag = "Newobjs";
		}
					
		if (transform.name.ToString().Equals("pos_wall2_6")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.31f, 1.479f, -3.195f);
			obj.transform.eulerAngles = new Vector3(0f, -90f, 0f);
			obj.tag = "Newobjs";
		}
					
		if (transform.name.ToString().Equals("pos_wall2_7")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.315f, 1.453f, -1.988f);
			obj.transform.eulerAngles = new Vector3(0f, -90f, 0f);
			obj.tag = "Newobjs";
		}

							
		if (transform.name.ToString().Equals("pos_wall3_1")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-0.344f, 1.486f, -11.939f);
			obj.transform.eulerAngles = new Vector3(0f, -180f, 0f);
			obj.tag = "Newobjs";
		}			
		
		if (transform.name.ToString().Equals("pos_wall3_2")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.208f, 1.482f, -11.947f);
			obj.transform.eulerAngles = new Vector3(0f, -180f, 0f);
			obj.tag = "Newobjs";
		}
				
		if (transform.name.ToString().Equals("pos_wall3_3")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-3.827f, 1.472f, -11.965f);
			obj.transform.eulerAngles = new Vector3(0f, -180f, 0f);
			obj.tag = "Newobjs";
		}

		if (transform.name.ToString().Equals("pos_wall3_4")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-5.224f, 1.469f, -11.935f);
			obj.transform.eulerAngles = new Vector3(0f, -180f, 0f);
			obj.tag = "Newobjs";
		}
				
		if (transform.name.ToString().Equals("pos_wall3_5")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-6.789f, 1.431f, -11.923f);
			obj.transform.eulerAngles = new Vector3(0f, -180f, 0f);
			obj.tag = "Newobjs";
		}

				
		if (transform.name.ToString().Equals("pos_wall4_1")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-7.978f, 1.487f, -10.067f);
			obj.transform.eulerAngles = new Vector3(0f, -90f, 0f);
			obj.tag = "Newobjs";
		}

						
		if (transform.name.ToString().Equals("pos_wall4_3")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-7.978f, 1.472f, -6.545f);
			obj.transform.eulerAngles = new Vector3(0f, -90f, 0f);
			obj.tag = "Newobjs";
		}
				
		if (transform.name.ToString().Equals("pos_wall4_4")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-7.978f, 1.501f, -4.778f);
			obj.transform.eulerAngles = new Vector3(0f, -90f, 0f);
			obj.tag = "Newobjs";
		}
						
		if (transform.name.ToString().Equals("pos_wall4_5")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-8.013f, 1.735f, -3.146f);
			obj.transform.eulerAngles = new Vector3(0f, -90f, 0f);
			obj.tag = "Newobjs";
		}
								
		if (transform.name.ToString().Equals("pos_wall4_6")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-7.991f, 1.528f, -1.391f);
			obj.transform.eulerAngles = new Vector3(0f, -90f, 0f);
			obj.tag = "Newobjs";
		}
										
		if (transform.name.ToString().Equals("pos_wall5_1")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-7.068f, 1.542f, 0.02f);
			obj.transform.eulerAngles = new Vector3(0f, 0f, 0f);
			obj.tag = "Newobjs";
		}
												
		if (transform.name.ToString().Equals("pos_wall5_2")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-3.987f, 1.542f, 0.044f);
			obj.transform.eulerAngles = new Vector3(0f, 0f, 0f);
			obj.tag = "Newobjs";
		}

														
		if (transform.name.ToString().Equals("pos_wall6_1")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.961f, 1.287f, -2.017f);
			obj.transform.eulerAngles = new Vector3(0f, 90f, 0f);
			obj.tag = "Newobjs";
		}
																
		if (transform.name.ToString().Equals("pos_wall6_2")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.961f, 1.651f, -2.7399f);
			obj.transform.eulerAngles = new Vector3(0f, 90f, 0f);
			obj.tag = "Newobjs";
		}
																		
		if (transform.name.ToString().Equals("pos_wall6_3")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.961f, 1.4309f, -3.748f);
			obj.transform.eulerAngles = new Vector3(0f, 90f, 0f);
			obj.tag = "Newobjs";
		}
										
		if (transform.name.ToString().Equals("pos_wall6_4")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.945f, 1.428f, -5.033f);
			obj.transform.eulerAngles = new Vector3(0f, 90f, 0f);
			obj.tag = "Newobjs";
		}
												
		if (transform.name.ToString().Equals("pos_wall6_5")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.941f, 1.474f, -6.347f);
			obj.transform.eulerAngles = new Vector3(0f, 90f, 0f);
			obj.tag = "Newobjs";
		}
												
		if (transform.name.ToString().Equals("pos_wall6_6")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.933f, 1.684f, -7.344f);
			obj.transform.eulerAngles = new Vector3(0f, 90f, 0f);
			obj.tag = "Newobjs";
		}

														
		if (transform.name.ToString().Equals("pos_wall6_7")) 
		{
			GameObject obj = Instantiate(eventData.lastPress.GetComponent<SlotItem>().ArtPrefab) as GameObject;
			//GameObject obj = Instantiate( GameManager_Curator.Instance.obj_Craft.Find(x => x.craftImage.Contains(eventData.pointerDrag)) ) as GameObject;

			obj.transform.position = new Vector3(-2.917f, 1.2241f, -7.633f);
			obj.transform.eulerAngles = new Vector3(0f, 90f, 0f);
			obj.tag = "Newobjs";
		}




	}
	#endregion
}
