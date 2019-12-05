using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {

<<<<<<< HEAD
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
=======
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

    public string getName()
    {
        return this.name;
    }

    public GameObject getGameObject()
    {
        return this.go;
>>>>>>> d8ea07e29c7e8989b3107383b07f871f999015f9
    }
}
