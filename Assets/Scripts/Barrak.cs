using UnityEngine;

public class Barrak : MonoBehaviour
{

    [SerializeField] private Unit _unitPrefab;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private Vector3 _directional;

    public void Spawn()
    {
       Unit unit= Instantiate(_unitPrefab,transform.position,transform.rotation);
       unit.Init(_rotation, _directional);
    }
}
