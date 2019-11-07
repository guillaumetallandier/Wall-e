using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApiRegle
{
    [JsonProperty("data")]
    private List<Regle> regles;

    public List<Regle> getRegles()
    {
        return this.regles;
    }

}

