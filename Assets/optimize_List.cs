using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optimize_List : MonoBehaviour
{
    private Set_Items_Data[] list_Item;
    private float current_Y;
    // Start is called before the first frame update
    void Start()
    {
        list_Item = GetComponentsInChildren<Set_Items_Data>();
        current_Y = GetComponent<RectTransform>().position.y;
        Debug.Log(current_Y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
    }
}
