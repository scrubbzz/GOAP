using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionBase : MonoBehaviour
{

    List<string> prerequisites = new List<string>();
    List<string> effects = new List<string> ();
   
    public abstract void Execute();
   
    
}
