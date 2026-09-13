// Console.WriteLine("Hello, World!");

// string myName = "Иван Иванов";
// string groupName = "ИСП-123";
// int age = 18;
// double averageGrade = 4.5;
// bool isStudent = true;

// Console.WriteLine($"Имя: {myName}");
// Console.WriteLine($"Группа: {groupName}");
// Console.WriteLine($"Возраст: {age}");
// Console.WriteLine($"Средний балл: {averageGrade}");
// Console.WriteLine($"Студент: {isStudent}");

// double roomLength = 5.5;

        // double roomWidth = 3.2;

// double roomArea = roomLength * roomWidth;
// double roomPerimeter = 2 * (roomLength + roomWidth);

// Console.WriteLine($"Длина: {roomLength} м");
// Console.WriteLine($"Ширина: {roomWidth} м");
// Console.WriteLine($"Площадь: {roomArea:F2} м²");
// Console.WriteLine($"Периметр: {roomPerimeter:F2} м");

// int laptopPrice = 80000;
// double interestRate = 0.10;

// double interest = laptopPrice * interestRate;
// double totalPrice = laptopPrice + interest;

// Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
// Console.WriteLine($"Процент: {interestRate:P0}");
// Console.WriteLine($"Сумма процентов: {interest:F2} руб.");
// Console.WriteLine($"Итоговая стоимость: {totalPrice:F2} руб.");

// Console.WriteLine();
// Console.WriteLine("Внимание: деление int");

// int totalStudents = 25;
// int groupsCount = 4;

// int studentsPerGroupWrong = totalStudents / groupsCount;
// double studentsPerGroupCorrect = (double)totalStudents / groupsCount;

// Console.WriteLine($"25 / 4 как int:    {studentsPerGroupWrong}");
// Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");

// Console.WriteLine();
// Console.WriteLine("Способы собрать строку");

// string firstName = "Анна";
// string lastName = "Смирнова";

// string fullNameConcat = firstName + " " + lastName;

// string fullNameInterp = $"{firstName} {lastName}";

// string fullNameConcatMethod = string.Concat(firstName, " ", lastName);

// Console.WriteLine(fullNameConcat);
// Console.WriteLine(fullNameInterp);
// Console.WriteLine(fullNameConcatMethod);
// Console.WriteLine($"Все три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}");

Console.WriteLine();
Console.WriteLine("Константы");

const double VatRate = 0.20;
const string CollegeName = "ВФ ВолГУ";

double productPrice = 1000;
double priceWithVat = productPrice * (1 + VatRate);

Console.WriteLine($"Учебное заведение: {CollegeName}");
Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0}): {priceWithVat}");