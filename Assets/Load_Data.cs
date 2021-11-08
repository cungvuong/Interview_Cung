using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Load_Data : MonoBehaviour
{
    public static Load_Data instance;

    private void Awake()
    {
        Init();
        if(instance == null)
        {
            instance = this;
        }
    }

    public TextAsset json_Data;
    public Sprite[] list_Sprite;
    public GameObject Item_In_Shop;
    public GameObject Shop;
    public static int current_Id_Check;

    [System.Serializable]
    public class List_Items {
        public Data_Item[] items;
    }

    public List_Items list_Item = new List_Items();

    private void Start()
    {
    }

    private void Init()
    {
        list_Item = JsonUtility.FromJson<List_Items>(json_Data.text);
        list_Sprite = Resources.LoadAll<Sprite>("ShopItems");
        Shop.GetComponent<RectTransform>().sizeDelta = new Vector2(800f, 333f*400f);
        for (int i=0; i<list_Item.items.Length; i++)
        {
            Item_In_Shop.GetComponent<Set_Items_Data>().Set_Data(list_Item.items[i].price, list_Item.items[i].title, list_Sprite[i], list_Item.items[i].desc, list_Item.items[i].id);
            Instantiate(Item_In_Shop, Shop.transform);
        }
    }
}

