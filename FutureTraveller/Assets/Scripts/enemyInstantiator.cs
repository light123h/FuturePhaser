using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyInstantiator : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Transform [] position;

    private void Start()
    {
        InvokeRepeating("Instantiator", 2.5f, 2.5f);
    }
    private void Instantiator()
    {
        int random = Random.Range(0, position.Length);
            Instantiate(enemy, position[random].position, Quaternion.identity);
        
    }
}
