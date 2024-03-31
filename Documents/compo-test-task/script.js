// Получаем ссылки на кнопку "В корзину" и элемент с общей суммой товаров
const addToCartButton = document.getElementById('addToCartButton');
const cartTotalAmount = document.getElementById('cartTotalAmount');

// Устанавливаем начальное значение общей суммы товаров
let totalAmount = 144235;

// Добавляем обработчик события при клике на кнопку "В корзину"
addToCartButton.addEventListener('click', function() {
    // При добавлении товара увеличиваем общую сумму на его стоимость (предположим, что стоимость равна 1000 рублей)
    totalAmount += 122566;

    // Обновляем значение общей суммы товаров на странице
    cartTotalAmount.textContent = totalAmount.toLocaleString('ru-RU') + '₽';
});
