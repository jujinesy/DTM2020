//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class DragInventory : MonoBehaviour
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
using UnityEngine.UI;

public class DragInventory : MonoBehaviour, IHasChanged
{
	[SerializeField] Transform slots;
	[SerializeField] Text inventoryText;

	// Use this for initialization
	void Start()
	{
		HasChanged();
	}

	#region IHasChanged implementation
	public void HasChanged()
	{
		//System.Text.StringBuilder builder = new System.Text.StringBuilder();
		//builder.Append(" - ");
		//foreach (Transform slotTransform in slots)
		//{
		//	GameObject item = slotTransform.GetComponent<Slot>().item;
		//	if (item)
		//	{
		//		builder.Append(item.name);
		//		builder.Append(" - ");
		//	}
		//}
		//inventoryText.text = builder.ToString();
	}
	#endregion
}


namespace UnityEngine.EventSystems
{
	public interface IHasChanged : IEventSystemHandler
	{
		void HasChanged();
	}
}
