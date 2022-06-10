using UnityEngine;

public class SpawnComponent : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform position;
    [SerializeField] private Transform parent;

    public void Spawn() => Instantiate(prefab);

    public void SpawnInParent() => Instantiate(prefab, parent);
}
