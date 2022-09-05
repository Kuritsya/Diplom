using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using System.Security.Permissions;

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

    public void txtToFile()
    {
        //Создание файла, в который необходимо записать текст
        StreamWriter sw = new StreamWriter(@"C:\\Diplom\\Diplom460\\Test.py");
        string resLine = "";
        string result = "";

        if (SceneManager.GetActiveScene().name == "Lvl_1")
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
        else if (SceneManager.GetActiveScene().name == "Lvl_2")
        {
            sw.WriteLine("k_1 = 0");
            sw.WriteLine("k_2 = 0");
            sw.WriteLine("k_3 = 0");
            sw.WriteLine(@"a_1 = '2230'");
            sw.WriteLine(@"a_2 = '-10'");
            sw.WriteLine(@"a_3 = '-100003'");
            sw.WriteLine("b_1 = [0]");
            sw.WriteLine("b_2 = [0]");
            sw.WriteLine("b_3 = [0]");
            sw.WriteLine("d_1 = 0");
            sw.WriteLine("d_2 = 0");
            sw.WriteLine("d_3 = 0");
            sw.WriteLine(@"res = ['', '', '']");
            result = "2230 -0 -10000 ";
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_3")
        {
            sw.WriteLine("k_1 = 3");
            sw.WriteLine("k_2 = 5");
            sw.WriteLine("k_3 = 4");
            sw.WriteLine(@"a_1 = 'RRG'");
            sw.WriteLine(@"a_2 = 'RRRRR'");
            sw.WriteLine(@"a_3 = 'BRBG'");
            sw.WriteLine("b_1 = 0");
            sw.WriteLine("b_2 = 0");
            sw.WriteLine("b_3 = 0");
            sw.WriteLine("d_1 = 0");
            sw.WriteLine("d_2 = 0");
            sw.WriteLine("d_3 = 0");
            sw.WriteLine(@"res = ['', '', '']");
            result = "1 4 0 ";
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_4")
        {
            sw.WriteLine("k_1 = 0");
            sw.WriteLine("k_2 = 0");
            sw.WriteLine("k_3 = 0");
            sw.WriteLine("a_1 = 4");
            sw.WriteLine("a_2 = 4");
            sw.WriteLine("a_3 = 1");
            sw.WriteLine("b_1 = 7");
            sw.WriteLine("b_2 = 9");
            sw.WriteLine("b_3 = 1");
            sw.WriteLine("d_1 = 0");
            sw.WriteLine("d_2 = 0");
            sw.WriteLine("d_3 = 0");
            sw.WriteLine(@"res = ['', '', '']");
            result = "2 3 1 ";
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_5")
        {
            sw.WriteLine("k_1 = 0");
            sw.WriteLine("k_2 = 0");
            sw.WriteLine("k_3 = 0");
            sw.WriteLine(@"a_1 = 'HoUse'");
            sw.WriteLine(@"a_2 = 'ViP'");
            sw.WriteLine(@"a_3 = 'maTRIx'");
            sw.WriteLine("b_1 = 0");
            sw.WriteLine("b_2 = 0");
            sw.WriteLine("b_3 = 0");
            sw.WriteLine("d_1 = 0");
            sw.WriteLine("d_2 = 0");
            sw.WriteLine("d_3 = 0");
            sw.WriteLine(@"res = ['', '', '']");
            result = "house VIP matrix ";
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_6")
        {
            sw.WriteLine("k_1 = 4");
            sw.WriteLine("k_2 = 0");
            sw.WriteLine("k_3 = 0");
            sw.WriteLine(@"a_1 = ['word', 'localization', 'internationalization', 'pneumonoultramicroscopicsilicovolcanoconiosis']");
            sw.WriteLine("a_2 = 0");
            sw.WriteLine("a_3 = 0");
            sw.WriteLine("b_1 = 0");
            sw.WriteLine("b_2 = 0");
            sw.WriteLine("b_3 = 0");
            sw.WriteLine("d_1 = 0");
            sw.WriteLine("d_2 = 0");
            sw.WriteLine("d_3 = 0");
            sw.WriteLine(@"res = ['', '', '']");
            result = "word 110n i18n p43s ";
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_7")
        {
            sw.WriteLine("k_1 = 0");
            sw.WriteLine("k_2 = 0");
            sw.WriteLine("k_3 = 0");
            sw.WriteLine(@"a_1 = 'code'");
            sw.WriteLine(@"a_2 = 'abb'");
            sw.WriteLine(@"a_3 = 'code'");
            sw.WriteLine(@"b_1 = 'edoc'");
            sw.WriteLine(@"b_2 = 'aba'");
            sw.WriteLine(@"b_3 = 'code'");
            sw.WriteLine("d_1 = 0");
            sw.WriteLine("d_2 = 0");
            sw.WriteLine("d_3 = 0");
            sw.WriteLine(@"res = ['', '', '']");
            result = "YES NO NO ";
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_8")
        {
            sw.WriteLine("k_1 = 3");
            sw.WriteLine("k_2 = 1");
            sw.WriteLine("k_3 = 0");
            sw.WriteLine("a_1 = [0, 0, 1]");
            sw.WriteLine("a_2 = [0]");
            sw.WriteLine("a_3 = 0");
            sw.WriteLine("b_1 = 0");
            sw.WriteLine("b_2 = 0");
            sw.WriteLine("b_3 = 0");
            sw.WriteLine("d_1 = 0");
            sw.WriteLine("d_2 = 0");
            sw.WriteLine("d_3 = 0");
            sw.WriteLine(@"res = ['', '', '']");
            result = "HARD EASY ";
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_9")
        {
            sw.WriteLine("k_1 = 1");
            sw.WriteLine("k_2 = 2");
            sw.WriteLine("k_3 = 3");
            sw.WriteLine("a_1 = 0");
            sw.WriteLine("a_2 = 0");
            sw.WriteLine("a_3 = 0");
            sw.WriteLine("b_1 = 0");
            sw.WriteLine("b_2 = 0");
            sw.WriteLine("b_3 = 0");
            sw.WriteLine("d_1 = 0");
            sw.WriteLine("d_2 = 0");
            sw.WriteLine("d_3 = 0");
            sw.WriteLine(@"res = ['', '', '']");
            result = "I hate it I hate that I love it I hate that I love that I hate it ";
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_10")
        {
            sw.WriteLine("k_1 = 5");
            sw.WriteLine("k_2 = 4");
            sw.WriteLine("k_3 = 0");
            sw.WriteLine("a_1 = [2, 4, 7, 8, 10]");
            sw.WriteLine("a_2 = [1, 2, 1, 1]");
            sw.WriteLine("a_3 = 0");
            sw.WriteLine("b_1 = 0");
            sw.WriteLine("b_2 = 0");
            sw.WriteLine("b_3 = 0");
            sw.WriteLine("d_1 = 0");
            sw.WriteLine("d_2 = 0");
            sw.WriteLine("d_3 = 0");
            sw.WriteLine(@"res = ['', '', '']");
            result = "3 2 ";
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_11")
        {
            sw.WriteLine("k_1 = 0");
            sw.WriteLine("k_2 = 0");
            sw.WriteLine("k_3 = 0");
            sw.WriteLine("a_1 = 117");
            sw.WriteLine("a_2 = 237");
            sw.WriteLine("a_3 = 15");
            sw.WriteLine("b_1 = 3");
            sw.WriteLine("b_2 = 7");
            sw.WriteLine("b_3 = 2");
            sw.WriteLine("d_1 = 0");
            sw.WriteLine("d_2 = 0");
            sw.WriteLine("d_3 = 0");
            sw.WriteLine(@"res = ['', '', '']");
            result = "9 1 2 ";
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_12")
        {
            sw.WriteLine("k_1 = 0");
            sw.WriteLine("k_2 = 0");
            sw.WriteLine("k_3 = 0");
            sw.WriteLine("a_1 = 3");
            sw.WriteLine("a_2 = 2");
            sw.WriteLine("a_3 = 7");
            sw.WriteLine("b_1 = 1");
            sw.WriteLine("b_2 = 3");
            sw.WriteLine("b_3 = 3");
            sw.WriteLine("d_1 = 0");
            sw.WriteLine("d_2 = 0");
            sw.WriteLine("d_3 = 0");
            sw.WriteLine(@"res = ['', '', '']");
            result = "1 1 2 0 3 2 ";
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_13")
        {
            sw.WriteLine("k_1 = 2");
            sw.WriteLine("k_2 = 3");
            sw.WriteLine("k_3 = 9");
            sw.WriteLine("a_1 = [1, 2]");
            sw.WriteLine("a_2 = [1, 2, 3]");
            sw.WriteLine("a_3 = [1, 2, 1, 3, 2, 2, 2, 2, 3]");
            sw.WriteLine("b_1 = 0");
            sw.WriteLine("b_2 = 0");
            sw.WriteLine("b_3 = 0");
            sw.WriteLine("d_1 = 0");
            sw.WriteLine("d_2 = 0");
            sw.WriteLine("d_3 = 0");
            sw.WriteLine(@"res = ['', '', '']");
            result = "2 4 10 ";
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_14")
        {
            sw.WriteLine("k_1 = 0");
            sw.WriteLine("k_2 = 0");
            sw.WriteLine("k_3 = 0");
            sw.WriteLine(@"a_1 = '1010100'");
            sw.WriteLine(@"a_2 = '000'");
            sw.WriteLine(@"a_3 = '1110'");
            sw.WriteLine(@"b_1 = '0100101'");
            sw.WriteLine(@"b_2 = '111'");
            sw.WriteLine(@"b_3 = '1010'");
            sw.WriteLine("d_1 = 0");
            sw.WriteLine("d_2 = 0");
            sw.WriteLine("d_3 = 0");
            sw.WriteLine(@"res = ['', '', '']");
            result = "1110001 111 0100 ";
        }

        if (field.text != string.Empty)
        {
            string[] arr = field.text.Split(sep, 100);
            bool protect = false;
            for (int i = 0; i < field.text.Length; i++)
            {
                if ((Convert.ToChar(arr[i]) >= Convert.ToChar("e") && Convert.ToChar(arr[i]) <= Convert.ToChar("j")) 
                    && (Convert.ToChar(arr[i]) >= Convert.ToChar("l") && Convert.ToChar(arr[i]) <= Convert.ToChar("z")))
                {
                    protect = false;
                }
                else
                {
                    protect = true;
                }
            }

            if(protect)
            {
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
                    //Закрытие файлов
                    sw.Close();

                    Process p = new Process();
                    ProcessStartInfo start = new ProcessStartInfo();
                    p.StartInfo = new ProcessStartInfo(@"C:\\Python\\Python39\\python.exe", @"C:\\Diplom\\Diplom460\\Test.py");
                    p.Start();

                    p.WaitForExit();
                    try
                    {
                        StreamReader sr = new StreamReader(@"C:\\Diplom\\Diplom460\\test.txt");
                        // Открыть файл с использованием StreamReader
                        // Чтение файла и запись в переменную
                        resLine = sr.ReadToEnd();
                        sr.Close();
                    }
                    catch (IOException e)
                    {
                        UnityEngine.Debug.Log("The file could not be read:");
                        UnityEngine.Debug.Log(e.Message);
                    }

                    window.SetActive(true);
                    canvas.SetActive(false);
                    UnityEngine.Debug.Log(resLine);
                    if (resLine == result)
                    {
                        UnityEngine.Debug.Log(resLine);
                        UnityEngine.Debug.Log("Правильно!");
                        windowRight.SetActive(true);
                    }
                    else
                    {
                        UnityEngine.Debug.Log("Неправильно");
                        windowError.SetActive(true);
                    }
                }
                catch (Exception e)
                {
                    UnityEngine.Debug.Log("Exception: " + e.Message);
                }
            }
            else
            {
                UnityEngine.Debug.Log("Неправильно");
                canvas.SetActive(false);
                windowError.SetActive(true);
            }
        }
        else
        {
            UnityEngine.Debug.Log("Пусто");
            window.SetActive(true);
            canvas.SetActive(false);
            windowEmpty.SetActive(true);
        }

        try
        {
            // Очистка файла
            for (int i = 0; i < field.text.Length; i++)
            {
                File.WriteAllText(@"C:\\Diplom\\Diplom460\\test.txt", string.Empty);
            }
        }
        catch (IOException e)
        {
            UnityEngine.Debug.Log("The file could not be empty:");
            UnityEngine.Debug.Log(e.Message);
        }
    }
}
