using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_1 {
    interface IView {

        // Вывод значения по Фаренгейту
        void PrintFahrenheit(double value);

        // Вывод значения по Цельсию
        void PrintCelsius(double value);

        // Ввод нового значения
        double InputDegrees { get; }

        // Событие ввода значения по Фаренгейту
        event EventHandler<EventArgs> OnSetFahrenheit;

        // Событие ввода значения по Цельсию
        event EventHandler<EventArgs> OnSetCelsius;
    }
}
