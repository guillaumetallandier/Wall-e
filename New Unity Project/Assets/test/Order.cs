using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order {

    private Personne _commander;
    private string _ordre;

    public Order(Personne commander, string ordre)
    {
        _commander = commander;
        _ordre = ordre;
    }
}
