using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player2D player = collision.gameObject.GetComponent<Player2D>();
            player.coin += 1;
            Destroy(gameObject);
        }
    }
}
