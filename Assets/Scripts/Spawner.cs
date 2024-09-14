using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Barrak[] _barrak;
    [SerializeField] private float delay = 2f;

    private void Start()
    {
        StartCoroutine(CreateUnit());
    }

    private IEnumerator CreateUnit()
    {
        WaitForSeconds wait = new(delay);

        while (enabled)
        {
            yield return wait;

            GetRandomBarrak().Spawn();
        }
    }

    private Barrak GetRandomBarrak()
    {
        return _barrak[Random.Range(0, _barrak.Length)];
    }
}
