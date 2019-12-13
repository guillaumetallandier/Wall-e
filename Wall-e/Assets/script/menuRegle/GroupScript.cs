using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject selection;
    public GameObject addRule;
    public Transform contentPanel;
    private int nextNum;
    void Start()
    {
        this.nextNum = 1;
        Debug.Log(nextNum);
        Invoke("spawnSelection",0.25f);
        Invoke("spawnAddRule",0.50f);
    }

    public void spawnSelection()
    {
        GameObject spawnedGameObject = (GameObject)GameObject.Instantiate(selection);
        spawnedGameObject.GetComponent<SelectionScript>().Setup(this.nextNum);
        spawnedGameObject.SetActive(true);
        spawnedGameObject.transform.SetParent(contentPanel);
        this.nextNum++;
    }
    public void spawnSelection(int pos)
    {
        GameObject spawnedGameObject = (GameObject)GameObject.Instantiate(selection);
        spawnedGameObject.GetComponent<SelectionScript>().Setup(this.nextNum);
        spawnedGameObject.SetActive(true);
        spawnedGameObject.transform.SetParent(contentPanel);
        spawnedGameObject.transform.SetSiblingIndex(pos);
        this.nextNum++;
    }
    public void spawnAddRule()
    {
        GameObject spawnedGameObject = (GameObject)GameObject.Instantiate(addRule);
        spawnedGameObject.SetActive(true);
        spawnedGameObject.transform.SetParent(contentPanel);
    }

}
