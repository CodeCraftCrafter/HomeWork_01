using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // ���������� ��� �������� ������ �� ��������� ������� Sphere
    public Collider sphereCollider;
    private int catchCount = 0; // ������� ��������� �����

    private void OnTriggerEnter(Collider other)
    {
        // ���������, ���������� �� ��������� � ����������� ������� Sphere
        if (other == sphereCollider)
        {
            catchCount++; // ����������� �������
            Debug.Log("��� ������: " + catchCount); // ������� ��������� � �������
        }
    }
}