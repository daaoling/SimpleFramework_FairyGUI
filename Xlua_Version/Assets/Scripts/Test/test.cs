using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        UnityEngine.Debug.Log(Application.dataPath);
        UnityEngine.Debug.Log(Application.persistentDataPath);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
