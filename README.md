# Eclipse-DNMV 
hakaton
Інструкція з установки коду:

1.	Коли ви відкриваєте наш репозиторій у Git Hub - переходьте на гілку «master» та запускайте проект.
2.	Завантажте необхідні файли файли з репозиторію на Git Hub.
3.	Перевірте наявність всіх файлів та їх імена в системі вашого пристрою. 
4.	Відкрийте репозиторій/завантажені файли у VS або VSC.
5.	Перевірте чи виникли у вас якісь помилки. Особливо зверніть увагу на залежності.
6.	Якщо помилки наявні, то спробуйте видалити та ще раз встановити всі файли або оновити БД(update-database). Для оновлення БД відкрійте консоль менеджеру пакетів та впишіть раніше згадану команду.
7.	Якщо у коді не має помилок можете сміливо запускати.(F5)

Опис проекту:

  Наша команда розробила сервіс, який відповідає за авторизацію користувачів деякого абстрактного застосунку. Наш сервіс підтримую авторизацію за допомогою електронної пошти, Google акаунту. Ми розробили API, яке надасть іншим сервісам можливість перевіряти валідність авторизаційних даних та реєструвати нових користувачів.

Він містить:

1. Реєстрацію користувачів: Користувачі мають можливість створити обліковий запис, використовуючи електронну пошту, Googleакаунт. 
2. Авторизацю користувачів: Користувачі мають можливість увійти в систему, використовуючи використаний раніше метод авторизації. 
3. Управління авторизаційними методами: Користувачі можуть змінювати та видаляти особисті дані: паролі та пошту (якщо користувачем було обрано варіант авторизації через пошту). А також підтримуються CRUD-операції. 
4. Захист інформації: Усі авторизаційні дані, такі як паролі або токени, збережені в безпечному і шифрованому вигляді. 
5. API для інших сервісів: надає API, за допомогою якого інші сервіси можуть реєструвати нових користувачів, перевіряє валідність авторизаційних даних та видаляє існуючі записи користувачів 
