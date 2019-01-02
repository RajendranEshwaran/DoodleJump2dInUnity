using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestrictionScript : MonoBehaviour {

    public Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("dfdfdfdfdfdfdfdfdfd f dfd");
        if(rb.tag == "Player")
        {

            SceneManager.LoadScene("GameOver");
        }

        
    }
}
