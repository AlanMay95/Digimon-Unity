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
            (new Digimon("YukimiBotamon",Resources.Load<Sprite>("13_YukimiBotamon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Yuramon",Resources.Load<Sprite>("14_Yuramon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Zurumon",Resources.Load<Sprite>("15_Zurumon"), 0, 0, 0, 0, 0, "na", "na", "na")),
            (new Digimon("Koromon",Resources.Load<Sprite>("16_Koromon"), 1, 10, 10, 10, 10, "Botamon", "na", "na")),
            (new Digimon("Tsunomon",Resources.Load<Sprite>("17_Tsunomon"), 1, 10, 10, 10, 10, "Punimon", "na", "na")),
            (new Digimon("Tokomon",Resources.Load<Sprite>("18_Tokomon"), 1, 10, 10, 10, 10, "Poyomon", "na", "na")),
            (new Digimon("Tanemon",Resources.Load<Sprite>("19_Tanemon"), 1, 10, 10, 10, 10, "Yuramon", "na", "na")),
            (new Digimon("Pagumon",Resources.Load<Sprite>("20_Pagumon"), 1, 10, 10, 10, 10, "Zurumon", "na", "na")),
            (new Digimon("Motimon",Resources.Load<Sprite>("21_Motimon"), 1, 10, 10, 10, 10, "Pubumon", "na", "na")),
            (new Digimon("Bukamon",Resources.Load<Sprite>("22_Bukamon"), 1, 10, 10, 10, 10, "Pichimon", "na", "na")),
            (new Digimon("DemiMeramon",Resources.Load<Sprite>("23_Demimeramon"), 1, 10, 10, 10, 10, "Mokumon", "na", "na")),
            (new Digimon("Yokomon",Resources.Load<Sprite>("24_Yokomon"), 1, 10, 10, 10, 10, "Nyokimon", "na", "na")),
            (new Digimon("Kapurimon",Resources.Load<Sprite>("25_Kapurimon"), 1, 10, 10, 10, 10, "Choromon", "na", "na")),
            (new Digimon("Nyaromon",Resources.Load<Sprite>("26_Nyaromon"), 1, 10, 10, 10, 10, "Yukimi Botamon", "na", "na")),
            (new Digimon("DemiVeemon",Resources.Load<Sprite>("27_Demiveemon"), 1, 10, 10, 10, 10, "Chibomon", "na", "na")),
            (new Digimon("Poromon",Resources.Load<Sprite>("28_Poromon"), 1, 10, 10, 10, 10, "Pururumon", "na", "na")),
            (new Digimon("Upamon",Resources.Load<Sprite>("29_Upamon"), 1, 10, 10, 10, 10, "Tsubumon", "na", "na")),
            (new Digimon("Minomon",Resources.Load<Sprite>("30_Minomon"), 1, 10, 10, 10, 10, "Leafmon", "na", "na")),
            (new Digimon("Gummymon",Resources.Load<Sprite>("31_Gummymon"), 1, 10, 10, 10, 10, "Zerimon", "na", "na")),
            (new Digimon("Agumon",Resources.Load<Sprite>("Agumon"), 2, 50, 50, 50, 50, "Koromon", "na", "na")),
            (new Digimon("Armadillomon",Resources.Load<Sprite>("Armadillomon"), 2, 50, 50, 50, 50, "Upamon", "na", "na")),
            (new Digimon("Betamon",Resources.Load<Sprite>("Betamon"), 2, 50, 50, 50, 50, "Bukamon", "Koromon", "na")),
            (new Digimon("Biyomon",Resources.Load<Sprite>("Biyomon"), 2, 50, 50, 50, 50, "Yokomon", "na", "na")),
            (new Digimon("Candlemon",Resources.Load<Sprite>("Candlemon"), 2, 50, 50, 50, 50, "DemiMeramon", "na", "na")),
            (new Digimon("Crabmon",Resources.Load<Sprite>("Crabmon"), 2, 50, 50, 50, 50, "Poyomon", "na", "na")),
            (new Digimon("DemmiDevimon",Resources.Load<Sprite>("DemiDevimon"), 2, 50, 50, 50, 50, "Pagumon", "na", "na")),
            (new Digimon("Elecmon",Resources.Load<Sprite>("Elecmon"), 2, 50, 50, 50, 50, "Tsunomon", "na", "na")),
            (new Digimon("Floramon",Resources.Load<Sprite>("Floramon"), 2, 50, 50, 50, 50, "Tanemon", "na", "na")),
            (new Digimon("Gabumon",Resources.Load<Sprite>("Gabumon"), 2, 50, 50, 50, 50, "Tsunomon", "na", "na")),
            (new Digimon("Gazimon",Resources.Load<Sprite>("Gazimon"), 2, 50, 50, 50, 50, "Pagumon", "na", "na")),
            (new Digimon("Gizamon",Resources.Load<Sprite>("Gizamon"), 2, 50, 50, 50, 50, "Pagumon", "na", "na")),
            (new Digimon("Goblimon",Resources.Load<Sprite>("Goblimon"), 2, 50, 50, 50, 50, "Pagumon", "na", "na")),
            (new Digimon("Gomamon",Resources.Load<Sprite>("Gomamon"), 2, 50, 50, 50, 50, "Bukamon", "na", "na")),
            (new Digimon("Gotsumon",Resources.Load<Sprite>("Gotsumon"), 2, 50, 50, 50, 50, "Pagumon", "na", "na")),
            (new Digimon("Hagurumon",Resources.Load<Sprite>("Hagurumon"), 2, 50, 50, 50, 50, "Kapurimon", "na", "na")),
            (new Digimon("Hawkmon",Resources.Load<Sprite>("Hawkmon"), 2, 50, 50, 50, 50, "Poromon", "na", "na")),
            (new Digimon("Kokuwamon",Resources.Load<Sprite>("Kokuwamon"), 2, 50, 50, 50, 50, "Kapurimon", "na", "na")),
            (new Digimon("Kunemon",Resources.Load<Sprite>("Kunemon"), 2, 50, 50, 50, 50, "Minomon", "na", "na")),
            (new Digimon("Mushroomon",Resources.Load<Sprite>("Mushroomon"), 2, 50, 50, 50, 50, "Tanemon", "na", "na")),
            (new Digimon("Otamamon",Resources.Load<Sprite>("Otamamon"), 2, 50, 50, 50, 50, "Bukamon", "na", "na")),
            (new Digimon("Palmon",Resources.Load<Sprite>("Palmon"), 2, 50, 50, 50, 50, "Tanemon", "na", "na")),
            (new Digimon("Patamon",Resources.Load<Sprite>("Patamon"), 2, 50, 50, 50, 50, "Tokomon", "na", "na")),
            (new Digimon("Penguinmon",Resources.Load<Sprite>("Pemguinmon"), 2, 50, 50, 50, 50, "Bukamon", "na", "na")),
            (new Digimon("Salamon",Resources.Load<Sprite>("Salamon"), 2, 50, 50, 50, 50, "Nyaromon", "na", "na")),
            (new Digimon("Syakomon",Resources.Load<Sprite>("Syakomon"), 2, 50, 50, 50, 50, "Bukamon", "na", "na")),
            (new Digimon("Taprimon",Resources.Load<Sprite>("Tapirmon"), 2, 50, 50, 50, 50, "Tsunomon", "na", "na")),
            (new Digimon("Tentomon",Resources.Load<Sprite>("Tentomon"), 2, 50, 50, 50, 50, "Motimon", "na", "na")),
            (new Digimon("Terriermon",Resources.Load<Sprite>("Terriermon"), 2, 50, 50, 50, 50, "Gummymon", "na", "na")),
            (new Digimon("ToyAgumon",Resources.Load<Sprite>("ToyAgumon"), 2, 50, 50, 50, 50, "Kapurimon", "na", "na")),
            (new Digimon("Veemon",Resources.Load<Sprite>("Veemon"), 2, 50, 50, 50, 50, "DemiVeemonmon", "na", "na")),
            (new Digimon("Wormmon",Resources.Load<Sprite>("Wormmon"), 2, 50, 50, 50, 50, "Minomon", "na", "na")),


        };


}
