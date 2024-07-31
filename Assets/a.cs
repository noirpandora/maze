using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class a : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up")){
            transform.position+=transform.forward*0.5f;
        }
        if(Input.GetKey("right")){
            transform.Rotate(0,10,0);
        }
        if(Input.GetKey("left")){
            transform.Rotate(0,-10,0);
        }
        if(Input.GetKey("down")){
            transform.position+=transform.forward*-0.5f;
        }
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name=="GOAL"){
            SceneManager.LoadScene("GoalScene");
        }
    }
}
