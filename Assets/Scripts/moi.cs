using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moi : MonoBehaviour

    
{
    private float _vitesse = 1f;


    // Start is called before the first frame update
    void Start()
    {
        _vitesse = Random.Range(1f, 5f);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0 , 0, _vitesse * Time.deltaTime);
        if(transform.position.x > 6f){
            Debug.Log(gameObject.name);
        }
        
    }
}
