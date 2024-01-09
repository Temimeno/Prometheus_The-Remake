using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerOnewayPlatform : MonoBehaviour
{

    private GameObject currentOnewayPlatform;

    [SerializeField] private BoxCollider2D playerCollider;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("OnewayPlatform"))
        {
            currentOnewayPlatform = collision.gameObject;
        }
    }

    private void OnCollisionExit2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("OnewayPlatform"))
        {
            currentOnewayPlatform = null;
        }
    }

    public void DownPlatform(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (currentOnewayPlatform != null)
            {
                StartCoroutine(DisableCollision());
            }
        }
    }

    private IEnumerator DisableCollision()
    {
        BoxCollider2D platformCollider = currentOnewayPlatform.GetComponent<BoxCollider2D>();

        Physics2D.IgnoreCollision(playerCollider, platformCollider);
        yield return new WaitForSeconds(0.25f);
        Physics2D.IgnoreCollision(playerCollider, platformCollider, false);
    }
}
