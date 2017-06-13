using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptCards : ScriptableObject {

    public string name;
    public Rarity rarity;
    public short cost;
    public string effect;

    public enum Rarity
    {
        basic,common,rare,epic,legendary,special
    }
}
