using UnityEngine;
using System.Collections;

public class MoveSample : MonoBehaviour
{
    

	void Start(){
        iTween.MoveTo(gameObject, new Vector3(-40f, 1.5f, 5f), 5);
    }
    
}

