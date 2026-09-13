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

// Console.WriteLine();
// Console.WriteLine("Константы");

// const double VatRate = 0.20;
// const string CollegeName = "ВФ ВолГУ";

// double productPrice = 1000;
// double priceWithVat = productPrice * (1 + VatRate);

// Console.WriteLine($"Учебное заведение: {CollegeName}");
// Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0}): {priceWithVat}");

// Console.WriteLine();
// Console.WriteLine("Визитная карточка студента");

// string name = "Рита Пономарёва Алексеевна";
// const string group = "ИСП-251";
// int course = 2;
// string specialization = "09.02.11";

// int firstWork = 4;
// int secondWork = 5;
// int threeWork = 4;

// int work = (firstWork + secondWork + threeWork) / 3;

// bool sholaship = true;

// int allWeek = 18;
// int lastWeek = 2;

// int week = allWeek - lastWeek;

// Console.WriteLine($"ФИO: {name}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"Курс: {course}");
// Console.WriteLine($"Специальность: {specialization}");
// Console.WriteLine($"Средний балл за 3 работы: {work}");
// Console.WriteLine($"Стипендия положена (>= 4.0): {sholaship}");
// Console.WriteLine($"Учебных недель осталось в семестре: {week}");

// Console.WriteLine();
// Console.WriteLine("Финансовый мини-расчёт");

// int scholarship = 15000;
// int monthlyExpenses = 12000;

// int remainingPerMonth = scholarship - monthlyExpenses;

// const int MonthsInSemester = 4;
// int remainingPerSemester = remainingPerMonth * MonthsInSemester;

// Console.WriteLine($"Остаток за месяц: {remainingPerMonth} руб.");
// Console.WriteLine($"Остаток за семестр ({MonthsInSemester} мес.): {remainingPerSemester} руб.");


// Console.WriteLine();
// Console.WriteLine("Конвертер температур");

// double celsius = 23.5;

// const double FahrenheitMultiplier = 9.0;
// const double FahrenheitDivider = 5.0;
// const double FahrenheitOffset = 32.0;
// const double KelvinOffset = 273.15;

// double fahrenheit = celsius * FahrenheitMultiplier / FahrenheitDivider + FahrenheitOffset;

// double kelvin = celsius + KelvinOffset;

// Console.WriteLine( $"{celsius:F1}°C = {fahrenheit:F1}°F = {kelvin:F2}K");


using static System.Console;
Console.WriteLine();
Console.WriteLine("Найди и исправь ошибку");


Minutes = 500;
int minutesPerLesson = 45;

int fullLessons = totalMinutes / minutesPerLesson;
int remainingMinutes = totalMinutes % minutesPerLesson;

Console.WriteLine($"{totalMinutes} минут = {fullLessons} полных занятий + " + $"{remainingMinutes} минут.");
