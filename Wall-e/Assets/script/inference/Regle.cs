using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regle {

    public int id;
    public string tag;
    public string description;
    public bool doitEtreAPortee;

    public Regle(int id, string tag, string desc, bool estAPortee)
    {
        this.id = id;
        this.tag = tag;
        this.description = desc;
        this.doitEtreAPortee = estAPortee;
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

    public bool getProtee()
    {
        return this.doitEtreAPortee;
    }
}
