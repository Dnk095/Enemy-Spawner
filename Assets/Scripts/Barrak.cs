using UnityEngine;

public class Barrak : MonoBehaviour
{

    [SerializeField] private Unit _unitPrefab;
    [SerializeField] private Target _target;

    public void Spawn()
    {
        Unit unit = Instantiate(_unitPrefab, transform.position, transform.rotation);
        unit.Init(_target);
    }
}
