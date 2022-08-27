using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skybox : MonoBehaviour
{
 void Update ()
 {
     RenderSettings.skybox.SetFloat("_Rotation", Time.time*8);
     //To set the speed, just multiply Time.time with whatever amount you want.
 }
 }

