using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Set_Items_Data : MonoBehaviour
{
    public Text price_Ob;
    public Text name_Ob;
    public Image im_Ob;
    [HideInInspector]public string desb;
    public GameObject show_Desc;
    public int id;
    // Start is called before the first frame update

    private void OnEnable()
    {
        Debug.Log("Onenable");
    }
    void Start()
    {
    }

    public void Set_Data(int price_Item, string name_Item, Sprite im_Item, string _desb, int _id)
    {
        price_Ob.text = price_Item.ToString();
        name_Ob.text = name_Item;
        im_Ob.sprite = im_Item;
        desb = _desb;
        id = _id;
    }

    public void See_Detail()
    {
        Load_Data.current_Id_Check = this.id;
        if (!show_Desc.activeInHierarchy)
            Instantiate(show_Desc, transform.parent.parent.parent.parent);
    }
}
