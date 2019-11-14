using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private List<GameObject> dwarves = new List<GameObject>
    {

    };

    public void AddToList(GameObject dwarf)
    {
        dwarves.Add(dwarf);
    }
}