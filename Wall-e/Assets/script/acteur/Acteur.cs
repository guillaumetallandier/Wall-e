using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;


public class Acteur : Observable
{
    
    public string name;
    public Action action;
    private GameObject gm;
    public int vie;
    public Item item;

    public Acteur(string name,GameObject gm, int vie,Item item)
    {
        this.name = name;
        this.gm = gm;
        this.vie = vie;
        this.item = item;
    }

    public Item getItem()
    {
        return item;
    }
   
    public void setItem(Item item)
    {
        this.item = item;
    }

    public int getVie()
    {
        return vie;
    }

    public void setVie(int vie)
    {
        this.vie = vie;
    }

    public Action getAction()
    {
        return action;
    }

    public void setAction(Action action)
    {
        this.action = action;
    }
}
