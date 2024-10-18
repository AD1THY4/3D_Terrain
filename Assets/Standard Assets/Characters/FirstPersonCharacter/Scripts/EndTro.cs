using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTro : MonoBehaviour
{
    // create a gameobject to store the player
    public GameObject player; 

    // awake happes before anythign else
    void Awake()
    {
        // disable the player so they can't move
        player.SetActive(false);
    }

    // this method when called ends the cinematic
    public void EndCinematic()
    {
        // set our player to active so they can move
        player.SetActive(true);
        // delete the fly through camera as we dont need it anymore
        Destroy(this.gameObject);
     }

}
