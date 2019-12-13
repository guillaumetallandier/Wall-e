using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionInstanciation : Action
{
    private int id;
    private string tag;
    private List<int> listeRegle;


    public ActionInstanciation(int id, string tag, List<int> listeRegle)
    {
        this.id = id;
        this.tag = tag;
        this.listeRegle = listeRegle;
    }


    override public void execute(GameObject go, GameObject gm)
    {

    }
    public string getTag()
    {
        return this.tag;
    }

    public int getId()
    {
        return this.id;
    }

    public List<int> getRegleList()
    {
        return this.listeRegle;
    }

    public override string getType()
    {
        return "";
    }
}
