using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrosEnemigos : MonoBehaviour
{
    public GameObject car;
    public Vector3[] positions = new Vector3[2];
    void Start()
    {
        positions[0] = new Vector3(-1,7.5f);
        positions[1] = new Vector3(2.86f,7.5f);

        StartCoroutine(EnemyCreator());
    }

    IEnumerator EnemyCreator()
    {
        while (true)
        {
            Instantiate(car, positions[Random.Range(0,2)], new Quaternion(180, 0 ,0 , 180));
            yield return new WaitForSeconds(3);
        }
    }

    void Update()
    {
        
    }
}
