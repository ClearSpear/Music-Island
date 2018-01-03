using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBehaviorScript : MonoBehaviour {

    public GameObject audiosource;
    public Material inactiveMaterial;

    private GvrAudioSource gvrAS;

    // Use this for initialization
    void Start () {
        gvrAS = audiosource.GetComponent<GvrAudioSource>(); 
	}
	
	// Update is called once per frame
	void Update () {
		if( !gvrAS.isPlaying )
        {
            GetComponent<Renderer>().material.color = Color.red;
            GetComponent<Renderer>().material = inactiveMaterial;
        }
	}
}
