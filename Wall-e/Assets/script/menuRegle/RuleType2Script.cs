using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class RuleType2Script : RuleScript
{
    public Dropdown dd;
    public GameObject ParOrdre;
    private List<EnumPeople> who = new List<EnumPeople>();
    private GameObject son;
    public new void Setup(Regle r)
    {
        base.Setup(r);
    }

    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        base.getButton().onClick.AddListener(delegate
            {
                Destroy(this.son);
    
            }
            );

        dd.options.Add(new Dropdown.OptionData(){ text = "aucun" });
        dd.options.Add(new Dropdown.OptionData() { text = "Proprietaire" });
        dd.options.Add(new Dropdown.OptionData() { text = "Par ordre" });
        dd.options.Add(new Dropdown.OptionData() { text = "Par ordre de dangerosite" });
        dd.onValueChanged.AddListener(delegate
        {
            listen(dd.options[dd.value].text);
        });
    }

    

    public void listen(String p)
    {
        switch (p)
        {
            case "Proprietaire":
                Destroy(this.son);
                this.who.Clear();
                this.who.Add(EnumPeople.proprietaire);
                break;

            case "Par ordre":
                GameObject spawnedGameObject = (GameObject)GameObject.Instantiate(ParOrdre);
                spawnedGameObject.SetActive(true);
                spawnedGameObject.transform.SetParent(this.transform.parent);
                this.son = spawnedGameObject;
                Debug.Log(p);
                break;

            case "aucun":
                break;
            default:
                Destroy(this.son);
                this.who.Clear();
                this.who.Add(EnumPeople.aucun);
                break;
        }
    }

}
