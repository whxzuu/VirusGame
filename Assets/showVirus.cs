using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showVirus : MonoBehaviour
{
    public GameObject virus;
    public float waktuMin, waktuMax;
    public float posisiMin, posisiMax;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MunculVirus());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MunculVirus()
    {
        Instantiate(virus, transform.position + Vector3.right * Random.Range(posisiMin, posisiMax),
            Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(waktuMin, waktuMax));
        StartCoroutine(MunculVirus());
    }
}

