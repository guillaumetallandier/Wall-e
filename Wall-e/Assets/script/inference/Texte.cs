using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texte{

    public string tag;
    public string descrip; 

    public Texte(string tag, string desc)
    {
        this.tag = tag;
        this.descrip = desc;
    }

    public string getTag()
    {
        return this.tag; 
    }

    public string getDescription()
    {
        return this.descrip;
    }
	
}
