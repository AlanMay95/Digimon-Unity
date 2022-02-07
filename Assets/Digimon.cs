using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Digimon 
{
    public string Digi;
    public Sprite DigiSprite;
    public int stage;
    public int str;
    public int def;
    public int spd;
    public int brns;
    public string pre1;
    public string pre2;
    public string pre3;

    public Digimon(string Name,Sprite sprite, int Stage, int StrengthReq, int DefenseReq, int SpeedReq, int BrainsReq, string Previous1, string Previous2, string Previous3)
    {
        Digi = Name;
        DigiSprite = sprite;
        stage = Stage;
        str = StrengthReq;
        def = DefenseReq;
        spd = SpeedReq;
        brns = BrainsReq;
        pre1 = Previous1;
        pre2 = Previous2;
        pre3 = Previous3;
    }
}
