using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observable : MonoBehaviour
{
    private List<Observer> observerList;

    public void Setup()
    {
        this.observerList = new List<Observer>();
    }
    public void notifyObservers(string actionName, GameObject go)
    {
        foreach (Observer o in observerList)
        {
            o.notity(actionName, go);
        }
    }
    public void addObserver(Observer o)
    {
        observerList.Add(o);
    }
}

