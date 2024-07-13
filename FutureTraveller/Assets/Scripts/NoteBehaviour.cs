using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NoteBehaviour : MonoBehaviour
{
    float disableThis;
    [SerializeField] Vector3 directionProjectile;
    GameObject target;
    [SerializeField]float speed;

    private void Awake()
    {
        
    }
    private void Start()
    {
       

        target = GameObject.FindGameObjectWithTag("enemy");

        if (target != null)
        {
            directionProjectile = target.transform.position;

            gameObject.transform.DOLocalMove(directionProjectile, speed);
        }
        

    }

 

    public Vector3 GetDirection()
    {
        return directionProjectile;
    }


    private void Update()
    {
        
        disableThis -= Time.deltaTime;

        if (disableThis < 0)
        {
            Destroy(gameObject);
        }  
    }
}
