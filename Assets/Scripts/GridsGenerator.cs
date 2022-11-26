using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridsGenerator : MonoBehaviour
{
    // public int size = 9;   
    public Grid[] grids;
    // Start is called before the first frame update
    void Start()
    {
        // grids = new Grid[size];


    }

    // Update is called once per frame
    void Update()
    {

        for (int x = 0; x < grids.Length; x++) {
            // Grid grid = gameObject.AddComponent<Grid>();
            grids[x].transform.position = new Vector3((x % 3) * 50, 0, x * 50);
        } 
    }
}
