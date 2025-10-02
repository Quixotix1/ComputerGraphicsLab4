using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwapper : MonoBehaviour
{
    public Material[] materials;
    int currentMaterial;

    void Start()
    {
        GetComponent<MeshRenderer>().material = materials[0];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentMaterial++;
            if (currentMaterial == materials.Length) currentMaterial = 0;
            GetComponent<MeshRenderer>().material = materials[currentMaterial];
        }
    }
}
