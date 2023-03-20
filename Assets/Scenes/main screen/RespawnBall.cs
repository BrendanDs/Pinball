using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour
{
    [SerializeField] Transform ballSpawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(WaitToRespawn(collision));
    }
    IEnumerator WaitToRespawn(Collider2D collider)
    {
        yield return new WaitForSeconds(2);
        collider.attachedRigidbody.transform.position = ballSpawnPoint.position;
    }
}
