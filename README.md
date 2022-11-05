
# WebEX

Софтуер разработен с цел да извлича информация за сайт, а чрез API-то на whoisfreaks да взима информация относно домейна.


## Tech Stack

**Application:** C# , JSON , HTMLAgilityPack

**API:** Whoisfreaks.com

## Класове

#### API>ApiKey

```csharp
          public static string key = Properties.Settings.Default.apiKey;

```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `key` | `string` | **Задължителен**. Вашият API ключ |

#### API>domainData


| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `domain`      | `string` | **Задължителен**. Домейна, който проверявате |

#### API>getAuthor


| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |
* Този метод връща информация относно автора на уебсайта
#### API>getCharset


| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |


* Този метод връща използваният charset в уебсайта
#### API>getCompany
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |
* Този метод връща използваният компанията, която е разработила уебсайта
#### API>getContentType
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |
* Този метод връща типа на съдръжанието в уебсайта
#### API>getCssFiles
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |
* Този метод връща броя на CSS файловете в сайта
#### API>getDescription
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |
* Този метод връща описанието на уебсайта
#### API>getFavicon
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |
* Този метод връща иконата на уебсайта
#### API>getKeywords
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |
* Този метод връща ключовите думи на уебсайта
#### API>getLanguage
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |
* Този метод връща езика, който се използва в уебсайта
#### API>getOgDescription
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |
* Този метод връща OpenGraph описанието на уебсайта
#### API>getOgImage
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |
* Този метод връща OpenGraph снимката на уебсайта
#### API>getOgTitle
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |
* Този метод връща OpenGraph заглавието на сайта
#### API>getOgType
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |
* Този метод връща OpenGraph типа на сайта
#### API>getRobots
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |
* Този метод връща информация относно robots тага
#### API>getTitle
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `data`      | `string` | **Задължителен**. HTML Кода на домейна, който проверявате |
* Този метод връща заглавието на сайта
#### API>resolveDomain.Lookup(domain)
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `domain`      | `string` | **Задължителен**. Линк към уебсайта |
* Този метод извлича информация за уебсайта, който сте въвели

#### Команди
* Изтриване на конзолата
```csharp
cls()
```
* Извличане на данни за уебсайта
```csharp
lookup <website>
```
* Излизане от софтуера
```csharp
exit()
```
* Задаване на API-ключ
```csharp
setApi <KEY>
```
* Задаване на свойство
```csharp
setProperty <PROPERTY_TYPE> <PROPERTY_STATE>
```
* Рестартиране на софтуера
```csharp
reset()
```
* Показване на всички налични Команди
```csharp
showCommands()
```
#### Свойства
* Анимация при стартиране на софтуера
```csharp
setProperty startAnimation <PROPERTY_STATE> || --disable || --enable
Пример: setProperty startAnimation --disable
```
* Debug Data
```csharp
setProperty debugData <PROPERTY_STATE> || --disable || --enable
Пример: setProperty debugData --enable

```

#### ВАЖНО: Няма как да направя документация за всеки клас, затова съм написал само най-важното, ако имате въпроси, моля свържете се с мен чрез e-mail support@v-devs.online
