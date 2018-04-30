using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstersSpawner : MonoBehaviour
{

    public GameObject monster;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    // Update is called once per frame
    void Update()
    {

    }

    // memunculkan enemy setiap antara 5 sampai 7 detik.
    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(5f, 7f));
        Instantiate(monster, transform.position, Quaternion.identity);
        StartCoroutine(StartSpawning());
    }
}
