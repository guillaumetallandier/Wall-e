using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {

    private GameObject _go;
    private string _type;

    public Item(GameObject go, string type)
    {
        _go = go;
        _type = type;
    }

    public void Setup(GameObject go, string type)
    {
        _go = go;
        _type = type;
    }

    public GameObject getGO()
    {
        return _go;
    }

    public string getType()
    {
        return _type;
    }
}
