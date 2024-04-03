using UnityEngine;

public class PlayerPush : MonoBehaviour
{
    public float pushPower = 10f; // ���� ������������

    private void OnCollisionEnter(Collision other)
    {
        Rigidbody rb = other.collider.GetComponent<Rigidbody>();

        // ���������, ���� �� � �������������� ������� Rigidbody
        if (rb != null)
        {
            Vector3 pushDirection = other.transform.position - transform.position;
            pushDirection.y = 0; // �� ��������� ���� �����, ����� �� "������������" �������
            pushDirection.Normalize(); // ����������� ������ ��� ��������� ����������� ��� ��������� ��������

            // ��������� ���� ������������
            rb.AddForce(pushDirection * pushPower, ForceMode.Impulse);
        }
    }
}