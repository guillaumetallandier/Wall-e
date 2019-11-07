using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observable
{
    private List<Observer> observerList = new List<Observer>();

    public void notifyObservers(string actionName, Personne p)
    {
        foreach (Observer o in observerList)
        {
            o.notity(actionName, p);
        }
    }
    public void addObserver(Observer o)
    {
        observerList.Add(o);
    }
}

