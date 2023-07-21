using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoeScript : MonoBehaviour
{
	AudioSource myClip;
    // Start is called before the first frame update
    void Start()
    {
        myClip = GetComponent<AudioSource>();
    }

  void OnCollisionEnter(Collision collision)
  {
  	myClip.Play();

  }
}
