using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OptionPeople : Dropdown.OptionData
{
    private EnumPeople value;
    public OptionPeople(EnumPeople value) : base()
    {
        this.value = value;
    }
    public EnumPeople getValue()
    {
        return this.value;
    }
}
public class ParOrdreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown first;
    public Dropdown second;
    public Dropdown third;
    public Dropdown forth;

    private List<Dropdown> ddTab = new List<Dropdown>();

    void Start()
    {
        ddTab.Add(first);
        ddTab.Add(second);
        ddTab.Add(third);
        ddTab.Add(forth);
    
        foreach (Dropdown dd in ddTab)
        {
            for (int i = 0; i < Enum.GetNames(typeof(EnumPeople)).Length; i++)
            {
                dd.options.Add(new OptionPeople((EnumPeople)Enum.GetValues(typeof(EnumPeople)).GetValue(i)) { text = Enum.GetNames(typeof(EnumPeople))[i] }); ;
                
            }
           
            dd.onValueChanged.AddListener(delegate
            {
                ordreChanged(dd);
            });
        }
        
    }

    public void ordreChanged(Dropdown drop)
    {
        OptionPeople opOther;
        OptionPeople op = (OptionPeople)drop.options[drop.value];
        foreach(Dropdown dd in this.ddTab)
        {
            opOther = (OptionPeople)dd.options[dd.value];
            if (opOther.getValue() == op.getValue())
            {
                int temp = dd.value;
                dd.value = drop.value;
                drop.value = temp;
            }
        }
    }

}
