using UnityEngine;

public class Barrak : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Target _target;

    public void Spawn()
    {
        Enemy enemy = Instantiate(_enemyPrefab, transform.position, transform.rotation);
        enemy.Init(_target);
    }
}
