using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glowlight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(glowcycle()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator glowcycle()
    {
        yield return new WaitForSeconds(.1f);
        for (float glowintense = 1; glowintense <5; glowintense += .05f)
        {
            GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", new Color(05,06,09)*glowintense);
              yield return new WaitForSeconds(.01f);
        }
         for (float glowintense = 5; glowintense >1; glowintense -= .05f)
        {
            GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", new Color(05,06,09)*glowintense);
              yield return new WaitForSeconds(.01f);
        }
      StartCoroutine(glowcycle()); 
    }
}
