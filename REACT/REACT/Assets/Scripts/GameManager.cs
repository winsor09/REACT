﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    static GameManager instance;

    public static GameManager Instance
    { get { return instance ?? ((instance = new GameManager())); } }

}