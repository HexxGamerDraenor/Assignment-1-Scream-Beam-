using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour {
    public GameObject BeamSprite;

    private bool isFiring = false;
    private void Update()
    {
        if (isFiring == false)
        {
            BeamSprite.SetActive(false);
        }
    }

	//function for setting beam active

    public void Fire()
    {
        isFiring = true;
        BeamSprite.SetActive(true);
    }
    public void ReleaseFire()
    {
        isFiring = false;
    }
}
