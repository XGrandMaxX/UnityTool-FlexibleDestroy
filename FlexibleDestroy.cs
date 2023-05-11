using System.Collections;
using UnityEngine;

public class FlexibleDestroy : MonoBehaviour
{
    private IEnumerator despawnCoroutine;
    
    /// <summary>
    /// Pass the object you want to destroy and after what time
    /// </summary>
    internal void StartDespawn(Object obj, float time)
    {
        Debug.Log("START DESPAWN");
        despawnCoroutine = Despawn(obj, time);
        StartCoroutine(despawnCoroutine);
    }
    
    /// <summary>
    /// Stops the Despawn() coroutine
    /// </summary>
    internal void StopDespawn()
    {
        Debug.Log("STOP DESPAWN");
        if (despawnCoroutine != null)
        {
            StopCoroutine(despawnCoroutine);
            despawnCoroutine = null;
        }
    }
    
    private IEnumerator Despawn(Object obj, float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(obj);
        despawnCoroutine = null;
        Debug.Log("DESPAWNED");
        yield break;
    }
}
