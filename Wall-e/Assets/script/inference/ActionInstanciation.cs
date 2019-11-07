using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionInstanciation : Action
{
    private int id;
    private string tag;
    private List<int> regleList;


    public ActionInstanciation(int id, string tag, List<int> listeRegle)
    {
        this.id = id;
        this.tag = tag;
        this.regleList = new List<int>(listeRegle);
    }


    override public void execute(Personne p, Personne pAgit)
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
        return this.regleList;
    }

    public override string getType()
    {
        return "";
    }
}
