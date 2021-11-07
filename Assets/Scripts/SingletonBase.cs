using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonBase<T> where T:SingletonBase<T>
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if(instance==null)
            {
                instance = Activator.CreateInstance<T>();
            }
            return instance;
        }
    }
}
