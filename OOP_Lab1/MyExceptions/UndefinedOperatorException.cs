using System;

namespace OOP_Lab1.MyExceptions {
    public class UndefinedOperatorException : Exception {
        // Дополнительное поле (например, код ошибки)
        public int ErrorCode { get; }

        // Конструктор по умолчанию
        public UndefinedOperatorException() : base("Ошибка! Объект класса не был инициализирован или не найден") { }

        // Конструктор с сообщением
        public UndefinedOperatorException(string message) : base(message) { }

        // Конструктор с сообщением и внутренним исключением
        public UndefinedOperatorException(string message, Exception innerException) 
            : base(message, innerException) { }

        // Конструктор с сообщением и кодом ошибки
        public UndefinedOperatorException(string message, int errorCode) 
            : base(message)
        {
            ErrorCode = errorCode;
        }

        // Переопределение метода ToString() для удобного вывода информации
        public override string ToString()
        {
            return $"UndefinedOperatorException: {Message} (ErrorCode: {ErrorCode})";
        }
    }
}
