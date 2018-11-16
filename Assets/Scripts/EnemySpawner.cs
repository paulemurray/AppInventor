using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public float gravity = 0.05f;

    void Start ()
    {
       StartCoroutine (SpawnWaves ());
    }

    IEnumerator SpawnWaves ()
    {
        yield return new WaitForSeconds (startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = new Quaternion(0,0,0,0);
                GameObject hazardClone = Instantiate (hazard, spawnPosition, spawnRotation);
                hazardClone.GetComponent<Rigidbody2D>().gravityScale = gravity;
                yield return new WaitForSeconds (spawnWait);
            }
            yield return new WaitForSeconds (waveWait);

            hazardCount += Random.Range(1,3);
            Debug.Log("Enemy Count: " + hazardCount);

            gravity += 0.005f;
            Debug.Log("Speed: " + gravity);
        }
    } 
}
