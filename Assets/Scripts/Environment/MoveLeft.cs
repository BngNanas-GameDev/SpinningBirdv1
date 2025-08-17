using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float destroyXPosition = -10f;

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        
        if (transform.position.x < destroyXPosition)
        {
            Destroy(gameObject);
        }
    }
}