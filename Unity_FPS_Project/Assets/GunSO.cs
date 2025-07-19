using UnityEngine;

[CreateAssetMenu(fileName = "Default Gun", menuName = "SO/Gun", order = 100)]

public class GunSO : ScriptableObject
{
    [field:SerializeField] public float CoolTime { get; private set; }
    [field:SerializeField] public float BulletSpeed { get; private set; }
}
