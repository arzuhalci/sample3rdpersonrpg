using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMissionList : MonoBehaviour
{
    public Mission _mission;
    void Start() {
    
    }
    public void AddMission(Mission mission)
    {
        this.GetComponent<PlayerMissionList>()._mission = mission;
    }

    public bool CheckMissionReqs(Mission mission, PlayerInventory inv)
    {
        Item item = mission.mission_request;
        int item_amount = mission.mission_request_amount;
        if(inv.CheckInventoryItemAmount(item) >= item_amount)
        {
            return true;
        }
        return false;
    }
}
