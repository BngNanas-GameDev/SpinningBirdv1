using Unity.VisualScripting;
using UnityEngine;

public class DamageBuwung : MonoBehaviour
{
    [SerializeField] private HPbar Health;
    [SerializeField] private float damagePerHit = 25f;
    private float damageDeadzone = 100f;
    // [SerializeField] private string[] damageTag = { "Pipa", "Tanah" };
    // [SerializeField] private float hitCooldown = 0.5f;

    // private float lasHitTime = -999f;
    private void Reset()
    {
        // otomatis ambil komponen Health di burung
        Health = GetComponent<HPbar>();
    }

    // Event tabrakan fisik (collider isTrigger = false)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        TryHit(collision.collider.gameObject);
    }

    // Event trigger (collider isTrigger = true)
    private void OnTriggerEnter2D(Collider2D other)
    {
        TryHit(other.gameObject);
    }

    // Fungsi buatan sendiri, dipanggil dari atas
    private void TryHit(GameObject hitter)
    {
        if (Health == null) return;

        // Pastikan pipa/top/bottom diberi tag "Pipe"
        if (hitter.CompareTag("Pipa"))
        {
            Debug.Log("[Damage] Burung kena: " + hitter.name);
            Health.TakeDamage(damagePerHit);
        }
        if (Health == null) return;
        if (hitter.CompareTag("Tanah"))
        {
            Debug.Log("[Damage] Burung kena: " + hitter.name);
            Health.TakeDamage(damageDeadzone);
        } 
    }
}