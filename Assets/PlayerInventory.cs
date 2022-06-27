using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class PlayerInventory : MonoBehaviour
{
    public List<Item> inventory;
    public int inv_cap = 5;

    public Image panel;
    public List<Image> slots;

    public Sprite ruby_sprite;
    public Texture2D ruby_tex;

    public void Start()
    {
        foreach(var slot in panel.GetComponentsInChildren<Image>())
        {
            slots.Add(slot);
        }
        inventory = new List<Item>();
    }

    public void AddItemToInventory(GameObject go, Item item)
    {
        if (inventory.Count < inv_cap)
        {
            go.GetComponent<PlayerInventory>().inventory.Add(item);
            InventoryItemImage();
        }
    }
    
    public void InventoryItemImage()
    {
            int empty_slot = CheckInventorySlot();
        Debug.Log(empty_slot);
            if(empty_slot == -1)
            {
                Debug.Log("inventory is full");
            }

        slots[empty_slot].sprite = inventory.Last().item_image;
            
    }

    public int CheckInventorySlot()
    {
        for(int i = 0; i < 6; i++)
        {
            if (slots[i].GetComponent<Image>().sprite == null)
            {
                return i;
            }
        }
        return -1;

    }
    public int CheckInventoryItemAmount(Item item)
    {
        int item_amount = 0;
        for(int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].GetType() == item.GetType())
            {
                item_amount++;
            }
        }
        return item_amount;
    }
    public void ClearInventory()
    {
        for(int i = 0; i < inventory.Count; i++)
        {
            inventory.Remove(inventory[i]);
        }
    }
    public void ClearSlots()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i].name != "Panel")
            {
                slots[i].sprite = null;
            }
        }
    }
}
