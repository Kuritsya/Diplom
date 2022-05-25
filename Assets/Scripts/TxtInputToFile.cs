using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class TxtInputToFile : MonoBehaviour
{
    public InputField field;
    char[] sep = new char[] { '\n' };
    string fileName = @"C:\\Diplom\\Diplom460\\test.txt', 'w'";
    public GameObject window;
    public GameObject windowRight;
    public GameObject windowError;
    public GameObject windowEmpty;
    public GameObject canvas;
    public string result;

    public void txtToFile()
    {
        //Создание файла, в который необходимо записать текст
        StreamWriter sw = new StreamWriter("C:\\Diplom\\Diplom460\\Test.py");
        StreamReader sr = new StreamReader("C:\\Diplom\\Diplom460\\test.txt");
        string resLine;

        if (SceneManager.sceneCount == 1)
        {
            sw.WriteLine("k_1 = 3");
            sw.WriteLine("k_2 = 2");
            sw.WriteLine("k_3 = 3");
            sw.WriteLine("a_1 = [3, 2, 4]");
            sw.WriteLine("a_2 = [6, 1]");
            sw.WriteLine("a_3 = [3, 2, 4]");
            sw.WriteLine("b_1 = [5, 1, 2]");
            sw.WriteLine("b_2 = [1, 6]");
            sw.WriteLine("b_3 = [5, 3, 2]");
            sw.WriteLine("d_1 = 0");
            sw.WriteLine("d_2 = 0");
            sw.WriteLine("d_3 = 0");
            sw.WriteLine(@"res = ['', '', '']");
            result = "Mishka Frendship Chris ";
        }

        if (field.text != string.Empty)
        {
            string[] arr = field.text.Split(sep, 100);

            try
            {
                //Запись текста в файл
                sw.WriteLine("def tst(k, a, b, d):");
                sw.WriteLine("\tc = 0");
                for (int i = 0; i < arr.Length; i++)
                {
                    sw.WriteLine("\t" + arr[i]);
                }
                sw.WriteLine("\treturn c");

                sw.WriteLine("res[0] = tst(k_1, a_1, b_1, d_1)");
                sw.WriteLine("res[1] = tst(k_2, a_2, b_2, d_2)");
                sw.WriteLine("res[2] = tst(k_3, a_3, b_3, d_3)");
                sw.WriteLine("fileVar = open('" + fileName + ")");
                sw.WriteLine("for i in range(3):");
                sw.WriteLine("\tfileVar.write(res[i] + '" + " ')");
                sw.WriteLine("fileVar.close()");
                //Закрытие файла
                sw.Close();

                Process p = new Process();
                ProcessStartInfo start = new ProcessStartInfo();
                p.StartInfo = new ProcessStartInfo(@"C:\\Python\\Python39\\python.exe", @"C:\\Diplom\\Diplom460\\Test.py");
                p.Start();

                resLine = sr.ReadLine();
                if (resLine == result)
                {
                    window.SetActive(true);
                    canvas.SetActive(false);
                    windowRight.SetActive(true);
                }
                else
                {
                    window.SetActive(true);
                    canvas.SetActive(false);
                    windowError.SetActive(true);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        else
        {
            window.SetActive(true);
            canvas.SetActive(false);
            windowEmpty.SetActive(true);
        }

        //File.WriteAllText("C:\\Diplom\\Diplom460\\test.txt", string.Empty);
    }
}
