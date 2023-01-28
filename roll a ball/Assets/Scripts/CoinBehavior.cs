using Unity.VisualScripting;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.GameObject());
        other.GetComponent<GameHandler>().OnCoinCollected(other.GameObject());
    }
}
