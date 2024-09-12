using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Barrak[] _barrak;

    private void Start()
    {
        StartCoroutine(CreateUnit());
    }

    private IEnumerator CreateUnit()
    {
        float delay = 2f;

        WaitForSeconds wait = new(delay);

        while (enabled)
        {
            yield return wait;

            GetBarrak().Spawn();
        }
    }

    private Barrak GetBarrak()
    {
        return _barrak[Random.Range(0, _barrak.Length)];
    }
}
