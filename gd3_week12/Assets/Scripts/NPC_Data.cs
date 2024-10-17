using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="NPC Data", fileName = "New NPC Data")]
public class NPC_Data : ScriptableObject
{
    public string NPCname;
    public string description;

    public Sprite artwork;

    public int armourLevel;
    public int age;
    public bool isFriendly;


    public Color potionCOlor;
    public int healthEffect = 5;
    public int StaminaEffect = -10;
}
