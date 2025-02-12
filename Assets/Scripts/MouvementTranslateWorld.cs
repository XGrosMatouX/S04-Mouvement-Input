using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementTranslateWorld : MonoBehaviour

{
    //[SerializeReference] public float _y = 0f;
    //[SerializeReference] public float _x = 0f;
    //void Update()
    //{
    //transform.Translate( _y * Time.deltaTime, _x * Time.deltaTime, 0, Space.World);

    //Vector3 deplacement = new Vector3(1f, 0, 0);
    //transform.Translate(deplacement * Time.deltaTime, Space.World);
    //}
    [SerializeField] private Vector3  _direction;
    private void Update()
    {
        transform.Translate(_direction);
    }
}
