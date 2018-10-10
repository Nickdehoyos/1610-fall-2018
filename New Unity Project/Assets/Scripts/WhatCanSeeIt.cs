using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatCanSeeIt: ScriptableObject
{

    private float health;
    protected float PowerLevel;
    public float EnergyLevel;

    private void AddHealth()
    {
        health += 100;
    }

    protected void AddPower()
    {
        AddHealth();
    }

    public void AddEnergy()
    {
        
    }
    
}

public class ICanSeeIt: MonoBehaviour
{
    private WhatCanSeeIt NewObject;

    private void Start()
    {
        NewObject.EnergyLevel = 100;
        NewObject.AddEnergy();
    }
}

public class Child : WhatCanSeeIt
{
    void CallThings()
    {
        PowerLevel = 200;
        EnergyLevel = 300;
        AddPower();
        AddEnergy();
    }
}