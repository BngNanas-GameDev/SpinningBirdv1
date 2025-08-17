using UnityEngine;

public class SpawnPipa : MonoBehaviour
{
    [SerializeField] private GameObject pipa;
    [SerializeField] private float spawnrate = 3f;
    [SerializeField] private float minY = -1f;
    [SerializeField] private float minX = 3f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnrate)
        {
            SpawnP();
            timer = 0f;
        }
    }

    private void SpawnP()
    {
        float randomY = Random.Range(minY, minX);
        Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0f);
        Instantiate(pipa, spawnPos, Quaternion.identity);
        
    }
}