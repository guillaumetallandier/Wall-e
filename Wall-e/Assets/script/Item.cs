using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {

    public GameObject go;
    public string name;

    public Item(string name, GameObject go) 
    {
        this.name = name;
        this.go = go;
    }
    public void setName(string name)
    {
        this.name = name;
    }

    public void setGm(GameObject go)
    {
        this.go = go;
    }
    public void setUp(string name, GameObject g)
    {
        this.name = name;
        this.go = g;
    }
    public string getName()
    {
        return this.name;
    }

    public GameObject getGameObject()
    {
        return this.go;

    }
}
