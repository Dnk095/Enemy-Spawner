using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private Vector3 _directional;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Cleaner cleaner))
            Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(_directional * Time.deltaTime,Space.World);
    }

    public void Init(Vector3 rotation, Vector3 directional)
    {
        transform.rotation = Quaternion.Euler(rotation);
        _directional = directional;
    }
}
