using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        switch(tag)
        {
            case "Dead":
                GameManager.instance.GameEnd();
                break;

            case "Bouncer":
                GameManager.instance.UpdateScore(20, 1);
                break;
            case "Point":
                GameManager.instance.UpdateScore(40, 1);
                break;
            case "Side":
                GameManager.instance.UpdateScore(20, 0);
                break;
            case "Flipper":
                GameManager.instance.multiplier=1;
                break;
            default:
                break;
        }
    }
}
