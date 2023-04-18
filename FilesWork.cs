using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace XOREncryption
{
    class FilesWork
    {
        public static byte[] ReadFile(string filePath) // Функція зчитування тексту з файлу приймає шлях до файлу
        {
            byte[] fileContents = {}; // Текст файлу

            try //Спроба зчитати файл
            {
                fileContents = File.ReadAllBytes(filePath); //Зчитування файлу
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

        public static void LoadFile(string filePath, byte[] fileContents) //Функція запису тексту приймає шлях до файлу його зміст
        {
            File.WriteAllBytes(filePath, fileContents); //Запис тексту
        }
    }
}
