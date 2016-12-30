﻿using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

    public LevelManager levelManager;

    void OnTriggerEnter2D(Collider2D trigger)
    {
        levelManager.WinGame("Win");
    }

}
