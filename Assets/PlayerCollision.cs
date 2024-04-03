using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Переменная для хранения ссылки на коллайдер объекта Sphere
    public Collider sphereCollider;
    private int catchCount = 0; // Счетчик пойманных мячей

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, столкнулся ли коллайдер с коллайдером объекта Sphere
        if (other == sphereCollider)
        {
            catchCount++; // Увеличиваем счетчик
            Debug.Log("Мяч пойман: " + catchCount); // Выводим сообщение в консоль
        }
    }
}