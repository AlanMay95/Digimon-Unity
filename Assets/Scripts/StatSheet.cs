using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatSheet : MonoBehaviour
{
    public GameObject Stats;
    public string StatsText, DigiName, Stage, Str, Def, Spd, Brns, Hunger;


    // Update is called once per frame
    void Update()
    {
        var MyDigi = GameObject.Find("PlayerDigi").GetComponent<MyDigimon>();

        DigiName = "Digimon: " + MyDigi.MyDigi.Digi;
        Stage = "Stage: " + MyDigi.MyDigi.stage;
        Str = "Strength: " + MyDigi.strength;
        Def = "Defense: " + MyDigi.defense;
        Spd = "Speed: " + MyDigi.speed;
        Brns = "Brains: " + MyDigi.brains;
        Hunger = "Hunger: " + MyDigi.hunger;

        StatsText = DigiName + "\r\n" + Stage + "\r\n" + Str + "\r\n" + Def + "\r\n" + Spd + "\r\n" + Brns + "\r\n" + Hunger;

        Stats.GetComponent<TextMeshPro>().SetText(StatsText);
    }
}
