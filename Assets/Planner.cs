using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planner : MonoBehaviour
{
    public List<string> targetActions = new List<string>();
    public List<string> doableActions = new List<string>();

    public Patrolliing patrolliing;
    public Cleaning cleaning;
    public Charging charging;

    public string goal = "Clean Spot";
    // Start is called before the first frame update
    void Start()
    {
        targetActions.Add("Patrolling");
        targetActions.Add("Cleaning");
        targetActions.Add("Charging");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
