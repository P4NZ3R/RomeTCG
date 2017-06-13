using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptUnit : ScriptableObject 
{
    public string name;
    public int tier;
    public int damage;
    public int armor;
    public Faction faction;
    public Type type;
    public Features[] features;
    public string description;
    public Texture img;

    public enum Faction 
    {
        roman,averni,suebi,boii
    }

    public enum Type
    {
        infantry
    }

    public enum Features
    {
        pila,gladio,scutum,sword,shield,spear,club,axe
    }
}
