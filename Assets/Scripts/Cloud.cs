using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-10f, 10f), Random.Range(-7f, 7f), 0);
        float tempValue = Random.Range(0.25f, 1.25f);
        transform.localScale = new Vector3(tempValue, tempValue, tempValue);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, Random.Range(0.1f, 0.7f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
