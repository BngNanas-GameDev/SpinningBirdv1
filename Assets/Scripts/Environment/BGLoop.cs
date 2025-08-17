using UnityEngine;

public class BGLoop : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private float Lebar;

    private void Start()
    {
        Lebar = GetComponent<SpriteRenderer>().bounds.size.x;


    }
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < -Lebar)
        {
            transform.position += Vector3.right * Lebar * 2f;
            
        }
        
    }
}