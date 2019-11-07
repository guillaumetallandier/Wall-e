using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class ApiAction {
    [JsonProperty("data")]
    public List<ActionInstanciation> actions { get; set; }
    
}
