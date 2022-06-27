using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInventory _player_inventory = gameObject.GetComponent<PlayerInventory>();
        Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position, 3.0f);
        foreach(var hitcollider in hitColliders)
        {
            if(hitcollider.tag == "npc")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    gameObject.GetComponent<PlayerMissionList>().AddMission(hitcollider.GetComponent<NPCMissions>().npc_missions[0]);
                   Debug.Log(gameObject.GetComponent<PlayerMissionList>()._mission);
                }
                if (Input.GetKeyDown(KeyCode.T))
                {
                    _player_inventory.ClearInventory();
                    _player_inventory.ClearSlots();
                    Debug.Log(_player_inventory.inventory.Count);
                }
                
            }
            if(hitcollider.tag == "ruby mine")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Ruby _new_ruby = new Ruby();
                    this.GetComponent<PlayerInventory>().AddItemToInventory(gameObject, _new_ruby);
                    
                }
            }
        }
    }

}
