using System.Collections;
using UnityEngine;

public class ServerRack : MonoBehaviour
{
    [SerializeField] [Range(0f, 1)] private float timeStap = 0.08f;
    [SerializeField] private Light[] lights;

    void Start()
    {
        if(lights.Length == 0) return;
        StartCoroutine(BlickCorotune());
    }

    private IEnumerator BlickCorotune()
    {
        while (true)
        {
            for (int i = 0; i < lights.Length; ++i)
            {
                lights[i].enabled = Random.Range(0, 2) == 1 ? true : false;
            }
            yield return new WaitForSeconds(timeStap);
        }
    }
}
