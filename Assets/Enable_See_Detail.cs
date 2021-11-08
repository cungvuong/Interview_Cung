using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enable_See_Detail : MonoBehaviour
{
    public Text name_Item;
    public Text desb_Item;
    public Image image;

    private void OnEnable()
    {
        name_Item.text = Load_Data.instance.list_Item.items[Load_Data.current_Id_Check-1].title;
        desb_Item.text = Load_Data.instance.list_Item.items[Load_Data.current_Id_Check-1].desc;
        image.sprite = Load_Data.instance.list_Sprite[Load_Data.current_Id_Check-1];
    }

    public void Hide_This()
    {
        gameObject.SetActive(false);
    }
}
