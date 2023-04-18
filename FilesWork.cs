using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace XOREncryption
{
    class FilesWork
    {
        public static string ReadTextFile(string filePath) // Функція зчитування тексту з файлу приймає шлях до файлу
        {
            string fileContents = ""; // Текст файлу

            try //Спроба зчитати файл
            {
                fileContents = File.ReadAllText(filePath); //Зчитування файлу
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("File not found"); //Помилка незнаходження файлу
            }
            catch (Exception)
            {
                throw new Exception("Problems with file"); //Інші помилки
            }

            return fileContents; //Повернення тексту
        }

        public static void LoadTextFile(string fileContents, string filePath) //Функція запису тексту приймає шлях до файлу його зміст
        {
            File.WriteAllText(filePath, fileContents); //Запис тексту
        }
    }
}
