using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5.0f; // Скорость перемещения объекта

    void Update()
    {
        // Получаем ввод с  клавиатуры
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Создаем вектор перемещения
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Перемещаем объект
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}

