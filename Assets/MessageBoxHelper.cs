using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CafeDemoLeontevaPetrova.Assets
{
    class MessageBoxHelper

    {
        ///<summary>
        ///Показывает сообщение об ошибке
        ///</summary>
        ///<paran name="exception">Исключение</paran>
        public static void Error(Exception exception)
        {
            MessageBox.Show(exception.Message, exception.HelpLink, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        ///<summary>
        ///Показывает сообщение об ошибке
        ///</summary>
        ///<paran name="text">Текст ошибки</paran>
        ///<paran name="title">Заголовок ошибки</paran>
        public static void Error(string text, string title ="Ошибки")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        ///<summary>
        ///Показывает сообщение для информирования
        ///</summary>
        ///<paran name="text">Информация</paran>
        ///<paran name="title">Заголовок информации</paran>
        public static void Information(string text, string title = "Информация")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        ///<summary>
        ///Возвращает результат ответа пользователя при возникновении окна
        ///</summary>
        ///<paran name="text">Текст сообщения</paran>
        ///<paran name="title">Заголовок сообщения</paran>
        ///<returns>Результат ответа в формате true или false</returns>
        public static bool Question(string text, string title = "Вопрос")
        {
            return MessageBox.Show(text, title, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes;
        }
        ///<summary>
        ///Показывает окно для предупреждения пользователя
        ///</summary>
        ///<paran name="text">Текст предупреждения</paran>
        ///<paran name="title">Заголовок предупреждения</paran>
        public static void Warning (string text, string title = "Предупреждение")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
