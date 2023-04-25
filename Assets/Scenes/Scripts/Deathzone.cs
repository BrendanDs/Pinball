using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzone : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform ballSpawnPoint;

    private void Start()
    {
        GameObject newBall = Instantiate(ballPrefab);
        newBall.transform.position = ballSpawnPoint.position;

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        StartCoroutine(Wait(collider));
        Debug.Log("After the coroutine");
    }

    IEnumerator Wait(Collider2D collider)
    {
        yield return new WaitForSeconds(2);
        collider.transform.position = ballSpawnPoint.position;
        collider.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
}
