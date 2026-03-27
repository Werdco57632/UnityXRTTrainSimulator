using System;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Manager : MonoBehaviour
{
    [SerializeField] GameObject Man_Source_Master;
    [SerializeField] GameObject Woman_Source_Master;



    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    /*
    void SpawnNPC(Vector3 Position, Tuple NPC_param<int,int,int,int,bool>)
    {
        // create an NPC using the modular asset at given position
    }
    
    void SpawnNPC(Vector3 Position, string preset_name)
    {

        static readonly Dictionary<string, (int head_ID, int body_ID, int legs_ID, int feet_ID, bool female)> NPC_presets =
            new(StringComparer.OrdinalIgnoreCase) {
                { "Casual",     (0,0,0,0) },
                { "Suit",       (1,1,1,1) },
                { "Worker",     (2,2,2,2) },
                { "Default",    (3,3,3,3) }
            };



        SpawnNPC(Position, NPC_presets[preset_name]);
    }
    */
}
