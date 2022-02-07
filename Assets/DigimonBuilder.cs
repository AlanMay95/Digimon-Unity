using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigimonBuilder 
{

       public static readonly  List<Digimon> AllDigi = new List<Digimon>()
        {
            (new Digimon("Botamon",Resources.Load<Sprite>("0_Botamon"),0, 0, 0, 0, 0, "na","na","na")),
            (new Digimon("Punimon",Resources.Load<Sprite>("1_Punimon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Pabumon",Resources.Load<Sprite>("2_Bubbmon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Chibomon",Resources.Load<Sprite>("3_Chicomon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Choromon",Resources.Load<Sprite>("4_Choromon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Leafmon",Resources.Load<Sprite>("5_Leafmon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Mokumon",Resources.Load<Sprite>("6_Mokumon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Nyokimon",Resources.Load<Sprite>("7_Nyokimon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Pichimon",Resources.Load<Sprite>("8_Pitchmon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Poyomon",Resources.Load<Sprite>("9_Poyomon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Pururumon",Resources.Load<Sprite>("10_Pururumon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Zerimon",Resources.Load<Sprite>("11_Zerimon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Tsubumon",Resources.Load<Sprite>("12_Tsubumon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Yukimi Botamon",Resources.Load<Sprite>("13_Yukimi Botamon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Yuramon",Resources.Load<Sprite>("14_Yuramon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Zurumon",Resources.Load<Sprite>("15_Zurumon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Koromon",Resources.Load<Sprite>("16_Koromon"), 1, 10, 10, 10, 10, "Botamon", "na", "na")),
            (new Digimon("Tsunomon",Resources.Load<Sprite>("17_Tsunomon"), 1, 10, 10, 10, 10, "Punimon", "na", "na")),
            (new Digimon("Tokomon",Resources.Load<Sprite>("18_Tokomon"), 1, 10, 10, 10, 10, "Poyomon", "na", "na")),
            (new Digimon("Tanemon",Resources.Load<Sprite>("19_Tanemon"), 1, 10, 10, 10, 10, "Yuramon", "na", "na")),
            (new Digimon("Pagumon",Resources.Load<Sprite>("20_Pagumon"), 1, 10, 10, 10, 10, "Zurumon", "na", "na")),
            (new Digimon("Motimon",Resources.Load<Sprite>("21_Motimon"), 1, 10, 10, 10, 10, "Pubumon", "na", "na")),
            (new Digimon("Bakumon",Resources.Load<Sprite>("22_Bakumon"), 1, 10, 10, 10, 10, "Pichimon", "na", "na")),
            (new Digimon("DemiMeramon",Resources.Load<Sprite>("23_Demimeramon"), 1, 10, 10, 10, 10, "Mokumon", "na", "na")),
            (new Digimon("Yokomon",Resources.Load<Sprite>("24_Yokomon"), 1, 10, 10, 10, 10, "Nyokimon", "na", "na")),
            (new Digimon("Kapurimon",Resources.Load<Sprite>("25_Kapurimon"), 1, 10, 10, 10, 10, "Choromon", "na", "na")),
            (new Digimon("Nyaromon",Resources.Load<Sprite>("26_Nyaromon"), 1, 10, 10, 10, 10, "Yukimi Botamon", "na", "na")),
            (new Digimon("DemiVeemon",Resources.Load<Sprite>("27_Demiveemon"), 1, 10, 10, 10, 10, "Chibomon", "na", "na")),
            (new Digimon("Poromon",Resources.Load<Sprite>("28_Poromon"), 1, 10, 10, 10, 10, "Pururumon", "na", "na")),
            (new Digimon("Upamon",Resources.Load<Sprite>("29_Upamon"), 1, 10, 10, 10, 10, "Tsubumon", "na", "na")),
            (new Digimon("Minomon",Resources.Load<Sprite>("30_Minomon"), 1, 10, 10, 10, 10, "Leafmon", "na", "na")),
            (new Digimon("Gummymon",Resources.Load<Sprite>("31_Gummymon"), 1, 10, 10, 10, 10, "Zerimon", "na", "na")),
            //(new Digimon("Agumon", 2, 50, 50, 50, 50, "Koromon", "na", "na")),
            //(new Digimon("Gabumon", 2, 50, 50, 50, 50, "Tsunomon", "na", "na"))

        };


}
