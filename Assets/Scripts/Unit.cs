using UnityEngine;
using UnityEngine.UIElements;

public class Unit : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Cleaner cleaner))
            Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);
    }

    public void Init(Vector3 rotation)
    {
        transform.rotation = Quaternion.Euler(rotation);
    }
}
