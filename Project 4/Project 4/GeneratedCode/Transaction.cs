﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Transaction
{
    private Dictionary<string, Item> items = new Dictionary<string, Item>();
    private int id;
    private float total;
    private bool rebate;

    //potentially need to add a DateTime in order to get current date? Not positive yet.

    public float Total
    {
        get
        {
            float t = 0;
            foreach (Item i in items.Values)
            {
                t += i.Price * i.Amount; 
            }
            total = t;
            return total;
        }
    }

    public bool Rebate
    {
        get
        {
            return rebate;
        }
        set
        {
            rebate = value;
        }
    }

    public Dictionary<string, Item> Items
    {
        get
        {
            return items;
        }
    }

    public Transaction(int i)
    {
        id = i;
    }

    public int getID()
    {
        return id;
    }
    public Item getItem(string name)
    {
        if (items.ContainsKey(name))
        {
            return items[name];
        }
        return null;
    }


}

