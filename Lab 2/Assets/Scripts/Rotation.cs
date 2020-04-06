using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    private float velocity = 100;

    public GameObject prefab;
    private GameObject newObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, velocity, 0) * Time.deltaTime);

        if (Input.GetButtonDown("Submit") && prefab && !newObj)
        {
            newObj = Instantiate<GameObject>(prefab, new Vector3(-9.28f, 1.39f, -10.63f), Quaternion.identity);
        }
    }
}
