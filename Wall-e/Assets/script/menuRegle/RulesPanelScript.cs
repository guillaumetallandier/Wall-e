using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RulesPanelScript : MonoBehaviour
{
    public Button button;
    private List<EnumPeople> peopleList = new List<EnumPeople>();


   
    private void Start()
    {
        GameObject panel;
        panel= GameObject.FindGameObjectWithTag("Panel_text");
        panel.SetActive(false);

        this.button.onClick.AddListener(delegate
        {
            
            sendToRobot();
            panel.SetActive(true);
        });
    }

    public void sendToRobot()
    {
        List<Regle> listeRegle = new List<Regle>();


        foreach(RuleScript rl in gameObject.GetComponentsInChildren<RuleScript>())
        {
            listeRegle.Add(rl.getRegle());
        }

        GameObject.FindGameObjectWithTag("maitre").GetComponent<Master>().begin(listeRegle, this.peopleList);
        gameObject.SetActive(false);

        foreach(ParOrdreScript s1 in gameObject.GetComponentsInChildren<ParOrdreScript>())
        {
            peopleList.Add(((OptionPeople)s1.first.options[s1.first.value]).getValue());
            peopleList.Add(((OptionPeople)s1.second.options[s1.second.value]).getValue());
            peopleList.Add(((OptionPeople)s1.third.options[s1.third.value]).getValue());
            peopleList.Add(((OptionPeople)s1.forth.options[s1.forth.value]).getValue());
        }

    }
}
