﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    void StartState();

    void UpdateState();

    void ExitState();

}
