using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regle {

    public int id;
    public string tag;
    public string description;

    public Regle(int id, string tag, string desc)
    {
        this.id = id;
        this.tag = tag;
        this.description = desc;
    }

    public string getTag()
    {
        return this.tag;
    }

    public int getId()
    {
        return this.id;
    }

    public string getDescription()
    {
        return this.description;
    }
}
