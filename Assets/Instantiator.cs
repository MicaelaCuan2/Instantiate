using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public int numero;
    public GameObject objectToClone;

    public void CloneObject()
    {
        int num = 0;
        while (num < numero)
        {
            Instantiate(objectToClone);
            num++;
        }
    }
}
