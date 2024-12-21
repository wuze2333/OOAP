#include <iostream>
#include <fstream>
#include <map>
#include <queue>
#include <cstdlib>
#include <ctime>
#include <stdexcept>

using namespace std;

// Абстрактный базовый класс SBase, предоставляет унифицированный интерфейс для получения данных
class SBase
{
public:
    virtual int Get() = 0; // Чисто виртуальная функция, реализуемая в производных классах для получения данных
    virtual ~SBase() {}
}; 

// Класс SKbrd: получает данные с клавиатуры
class SKbrd : public SBase
{
public:
    int Get() override
    {
        int value;
        cout << "Введите целое число (отрицательное число для остановки): ";
        cin >> value;
        return value; // Возвращает введенное значение
    }
};

// Класс SFile: считывает данные из файла
class SFile : public SBase
{
private:
    ifstream file; // Объект файлового потока
public:
    SFile(const string& filename)
    {
        file.open(filename);
        if (!file) // Если файл не удалось открыть, выбрасывает исключение
        {
            throw runtime_error("Не удалось открыть файл: " + filename);
        }
    }

    ~SFile()
    {
        if (file.is_open())
        {
            file.close(); // Закрывает файл
        }
    }

    int Get() override
    {
        int value;
        if (file >> value)
        {
            return value; // Возвращает считанное число
        }
        return -1; // Конец файла или ошибка чтения
    }
};

// Класс SQueue: получает данные из заранее сформированной очереди случайных чисел
class SQueue : public SBase
{
private:
    queue<int> q; // Очередь
public:
    SQueue(int length)
    {
        srand(static_cast<unsigned int>(time(0)));
        for (int i = 0; i < length; ++i)
        {
            q.push(rand() % 100); // Генерирует случайное число и добавляет в очередь
        }
    }

    int Get() override
    {
        if (!q.empty())
        {
            int value = q.front();
            q.pop(); // Получает и удаляет элемент из передней части очереди
            return value;
        }
        return -1; // Очередь пуста
    }
};

// Класс Freq: подсчитывает частоту и сумму введенных чисел             //слышишь?
class Freq
{
protected:
    map<int, int> counts; // Сохраняет числа и их количество
    int sum = 0; // Сумма всех чисел
public:
    virtual void Calc(SBase* pobj)
    {
        int value;
        while ((value = pobj->Get()) >= 0)
        {
            ProcessValue(value); // Обрабатывает полученное значение
        }
    }

    virtual void ProcessValue(int value)
    {
        counts[value]++; // Увеличивает счетчик для данного значения
        sum += value; // Добавляет значение к сумме
    }

    friend ostream& operator<<(ostream& stream, const Freq& obj)
    {
        stream << "Частотная статистика:\n";
        for (const auto& pair : obj.counts)
        {
            stream << pair.first << ": " << pair.second << " раз(а)\n";
        }
        stream << "Сумма: " << obj.sum << "\n";
        return stream; // Выводит результаты статистики
    }
};

// Класс Diap: расширяет Freq, добавляет расчет минимального и максимального значений, а также количества элементов
class Diap : public Freq
{  ////Warning
    //    Unable to use the selected camera and /or microphone.Please, check that they work correctly and are not used by other application, or select another devices
private:
    int min = INT_MAX; // Минимальное значение
    int max = INT_MIN; // Максимальное значение
    int count = 0; // Количество элементов
public:
    void ProcessValue(int value) override
    {
        Freq::ProcessValue(value);
        if (value < min) min = value; // Обновляет минимальное значение
        if (value > max) max = value; // Обновляет максимальное значение
        count++; // Увеличивает количество элементов
    }

    friend ostream& operator<<(ostream& stream, const Diap& obj)
    {
        stream << "Частотная статистика:\n";
        for (const auto& pair : obj.counts)
        {
            stream << pair.first << ": " << pair.second << " раз(а)\n";
        }
        stream << "Сумма: " << obj.sum << "\n";
        if (obj.count > 0)
        {
            stream << "Минимум: " << obj.min << "\n";
            stream << "Максимум: " << obj.max << "\n";
            stream << "Количество: " << obj.count << "\n";
        }
        else
        {
            stream << "Нет действительных данных.\n";
        }
        return stream;
    }
};

// Основная функция: демонстрирует три способа получения данных и их обработку
int main()
{
    try
    {
        // Демонстрация с использованием SKbrd (ввод с клавиатуры)
        SKbrd keyboard;
        Freq freq1;
        cout << "\nВвод с клавиатуры:\n";
        freq1.Calc(&keyboard);
        cout << freq1;

        // Демонстрация с использованием SFile (ввод из файла)
        SFile file("numbers.txt");
        Freq freq2;
        cout << "\nВвод из файла:\n";
        freq2.Calc(&file);
        cout << freq2;

        // Демонстрация с использованием SQueue (ввод из очереди)
        SQueue queue(10);
        Diap diap1;
        cout << "\nВвод из очереди:\n";
        diap1.Calc(&queue);
        cout << diap1;
    }
    catch (const exception& e)
    {
        cerr << "Ошибка программы: " << e.what() << endl;
    }

    return 0;
}




/*
SBase (строки: 9-12): абстрактный базовый класс, определяющий чисто виртуальную
функцию Get() для реализации унифицированного интерфейса получения данных
из различных источников данных.

SKbrd (строки: 14-21): получает данные с клавиатуры и завершает работу,
когда пользователь вводит отрицательное число.

SFile (строки: 23-38): считывает данные из файла, выбрасывает исключение
при ошибке открытия файла.

SQueue (строки: 40-58): получение данных из заданной очереди случайных чисел,
возврат -1, если очередь пуста.

Freq (строки: 60-84): подсчитывает и сохраняет частоту и сумму введенных
неотрицательных целых чисел.

Diap (строки: 86-110): добавляет функцию вычисления и вывода минимального
значения, максимального значения и общего количества элементов в Freq.

Основные функции (строки: 112-148): объясняет, как обрабатывать данные с помощью
трех источников данных SKbrd, SFile и SQueue, а также с помощью классов
Freq и Diap.
*/
