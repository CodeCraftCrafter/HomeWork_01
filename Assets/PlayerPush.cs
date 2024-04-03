using UnityEngine;

public class PlayerPush : MonoBehaviour
{
    public float pushPower = 10f; // Сила отталкивания

    private void OnCollisionEnter(Collision other)
    {
        Rigidbody rb = other.collider.GetComponent<Rigidbody>();

        // Проверяем, есть ли у столкнувшегося объекта Rigidbody
        if (rb != null)
        {
            Vector3 pushDirection = other.transform.position - transform.position;
            pushDirection.y = 0; // Не добавляем силу вверх, чтобы не "подбрасывать" объекты
            pushDirection.Normalize(); // Нормализуем вектор для получения направления без изменения величины

            // Применяем силу отталкивания
            rb.AddForce(pushDirection * pushPower, ForceMode.Impulse);
        }
    }
}