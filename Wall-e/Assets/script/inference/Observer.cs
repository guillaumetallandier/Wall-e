﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Observer
{
    void notity(string actionName, GameObject go);
}
