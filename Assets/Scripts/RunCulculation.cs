using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunCulculation : MonoBehaviour {

    public int a;
    public int b;

	// Use this for initialization
	void Start () {
        Debug.Log(GetComponent<AmariCalcuration>().Amari(a, b));
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
