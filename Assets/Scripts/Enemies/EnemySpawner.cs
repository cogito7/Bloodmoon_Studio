using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject swarmerPrefab;
   
    [SerializeField] private float swarmerInterval = 3.5f;

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, swarmerPrefab));
        
    }

    // Update is called once per frame
    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        EnemyBehavior oldEnemyBehavior = swarmerPrefab.GetComponent<EnemyBehavior>();
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        newEnemy.GetComponent<EnemyBehavior>().player = player;
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
