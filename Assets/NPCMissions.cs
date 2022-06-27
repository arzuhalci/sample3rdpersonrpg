using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMissions : MonoBehaviour
{
    public List<Mission> npc_missions;
    
    public void Start()
    {
        npc_missions = new List<Mission>();
        Mission _mission = new Mission();
        _mission.mission_name = "Find Rubies";
        _mission.mission_reward = FindObjectOfType<ItemDatabase>().money;
        _mission.mission_text = "Go get some rubies";
        _mission.mission_request_amount = 2;
        npc_missions.Add(_mission);
    }
}
