using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayData : MonoBehaviour
{
    public TMP_Text npcName, description, armour, age, friendliness;
    public GameObject statsCard;
    public Image artwork;


    public void showStats(NPC_Data stats)
    {
        npcName.text = "Howdy, I is " + stats.NPCname;
        description.text = stats.description;
        armour.text = "I have " + stats.armourLevel + " armours";
        age.text = "I have " + stats.age + " years xp";

        if (stats.isFriendly) friendliness.text = "lets hook up sometimes";
        else friendliness.text = "GET AWAY FROM ME!!!!!";

        artwork.sprite = stats.artwork;

        statsCard.SetActive(true);
    }
}
