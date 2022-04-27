using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StemGrow : MonoBehaviour
{
    public List<MeshRenderer> stemGrowMeshes;
    public float timeToGrow = 5;
    public float refreshRate = 0.05f;
    [Range(0, 1)]
    public float minGrow = 0.2f;
    [Range(0, 1)]
    public float maxGrow = 0.97f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
